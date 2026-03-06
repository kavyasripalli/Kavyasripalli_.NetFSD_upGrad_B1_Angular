import Event from "../models/Event.js";
import { 
  getEvents, 
  addEvent, 
  updateEvent, 
  deleteEvent, 
  getEventById 
} from "../services/eventService.js";
import { getRegistrations } from "../services/registrationService.js";
import { showNotification } from "../utils/notification.js";

let allEvents = [];

const renderEvents = async (events) => {

  const eventList = document.getElementById("eventList");
  const registrations = await getRegistrations();

  eventList.innerHTML = "";

  if (events.length === 0) {
    eventList.innerHTML = "<p style='text-align: center; color: #555;'>No events available.</p>";
    return;
  }

  events.forEach((event) => {

    const today = new Date();
    today.setHours(0, 0, 0, 0);
    const eventDate = new Date(event.date);
    eventDate.setHours(0, 0, 0, 0);

    let statusBadge = "";

    if (eventDate < today) {
      statusBadge = `<span class="status completed">Event Completed</span>`;
    } else if (event.availableSeats === 0) {
      statusBadge = `<span class="status full">Event Full</span>`;
    } else {
      statusBadge = `<span class="status open">Seats Available</span>`;
    }

    const registrationCount = registrations.filter(
      (reg) => reg.eventId == event.id
    ).length;

    const isCompleted = eventDate < today;

    eventList.innerHTML += `
      <div class="event-card">
        <h3>${event.title}</h3>
        <p>${event.description}</p>
        <p><strong>Date:</strong> ${event.date}</p>
        <p><strong>Location:</strong> ${event.location}</p>
        <p><strong>Available Seats:</strong> ${event.availableSeats}</p>
        <p>${statusBadge}</p>
        <p><strong>Registrations:</strong> ${registrationCount}</p>

        <button onclick="editEvent(${event.id})" ${isCompleted ? "disabled" : ""}>Edit</button>
        <button onclick="removeEvent(${event.id})" ${isCompleted ? "disabled" : ""}>Delete</button>
      </div>
    `;
  });

};
export const loadEvents = async () => {
  const eventList = document.getElementById("eventList");
  eventList.innerHTML = "<p style='text-align: center; color: #555;'>Loading events...</p>";
  if (!eventList) return;

  try {
    allEvents = await getEvents();
    const events = allEvents;
    events.sort((a, b) => new Date(a.date) - new Date(b.date));

    eventList.innerHTML = "";

    renderEvents(events);
    } catch (error) {
    console.error(error);
  }
};

export const handleAddEvent = async (e) => {
  e.preventDefault();

  const params = new URLSearchParams(window.location.search);
  const id = params.get("id");

  const title = document.getElementById("title").value;
  const description = document.getElementById("description").value;
  const date = document.getElementById("date").value;
  const today = new Date().toISOString().split("T")[0];

  if (date < today) {
    showNotification("Cannot create event with past date!");
    return;
  }
  const location = document.getElementById("location").value;
  const capacity = parseInt(document.getElementById("capacity").value);

  let availableSeats = capacity;

  if (id) {
    const oldEvent = await getEventById(id);
    availableSeats = oldEvent.availableSeats;
  }

  const eventData = {
    id: id ? id : Date.now(),
    title,
    description,
    date,
    location,
    capacity,
    availableSeats
  };

  try {
    if (id) {
      await updateEvent(id, eventData);
      showNotification("Event updated successfully!");
    } else {
      await addEvent(eventData);
      showNotification("Event added successfully!");
    }

    setTimeout(() => {
      window.location.href = "index.html";
    }, 6000);

  } catch (error) {
    showNotification("Error saving event.");
  }
};

export const loadEventForEdit = async () => {
  const params = new URLSearchParams(window.location.search);
  const id = params.get("id");

  if (!id) return;

  const event = await getEventById(id);

  document.getElementById("title").value = event.title;
  document.getElementById("description").value = event.description;
  document.getElementById("date").value = event.date;
  document.getElementById("location").value = event.location;
  document.getElementById("capacity").value = event.capacity;
};

export const editEvent = async (id) => {
  window.location.href = `add-event.html?id=${id}`;
  };

export const removeEvent = async (id) => {

  const registrations = await getRegistrations();

  const hasRegistrations = registrations.some(
    (reg) => reg.eventId == id
  );

  if (hasRegistrations) {
    showNotification("Cannot delete event with registrations.");
    return;
  }

  const confirmDelete = confirm("Are you sure you want to delete this event?");
  if (!confirmDelete) return;

  try {
    await deleteEvent(id);
    showNotification("Event deleted successfully!");
    loadEvents();
  } catch (error) {
    showNotification("Error deleting event.");
  }
};

export const setupSearch = () => {

  const searchInput = document.getElementById("searchInput");

  if (!searchInput) return;

  searchInput.addEventListener("input", () => {

    const keyword = searchInput.value.toLowerCase();

    const filteredEvents = allEvents.filter(event =>
      event.title.toLowerCase().includes(keyword)
    );

    renderEvents(filteredEvents);

  });

};

window.removeEvent = removeEvent;
window.editEvent = editEvent;