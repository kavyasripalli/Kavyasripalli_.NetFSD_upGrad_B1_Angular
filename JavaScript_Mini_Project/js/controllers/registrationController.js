import Registration from "../models/Registration.js";
import { addRegistration } from "../services/registrationService.js";
import { getEventById, updateEvent, getEvents } from "../services/eventService.js";
import { showNotification } from "../utils/notification.js";

export const loadEventsForRegistration = async () => {
  const eventList = document.getElementById("eventList");

  try {
    const events = await getEvents();

    eventList.innerHTML = `
      <table border="1" cellpadding="10">
        <tr>
          <th>ID</th>
          <th>Title</th>
          <th>Date</th>
          <th>Location</th>
          <th>Available Seats</th>
        </tr>
      </table>
    `;

    const table = eventList.querySelector("table");

    events.forEach((event) => {
      const today = new Date();
      today.setHours(0, 0, 0, 0);
      const eventDate = new Date(event.date);
      eventDate.setHours(0, 0, 0, 0);
      if (eventDate < today) return;
      const row = document.createElement("tr");

      const seatsDisplay =
        event.availableSeats > 0
          ? event.availableSeats
          : "Registration Closed";

      row.innerHTML = `
        <td>${event.id}</td>
        <td>${event.title}</td>
        <td>${event.date}</td>
        <td>${event.location}</td>
        <td>${seatsDisplay}</td>
      `;

      if (event.availableSeats > 0) {
        row.addEventListener("click", () => {
          document.querySelectorAll("tr").forEach(r => { 
              r.style.backgroundColor = "";
            });
          row.style.backgroundColor = "#d4edda";
          document.getElementById("eventId").value = event.id;
        });
      } else {
        row.style.color = "gray";
      }

      table.appendChild(row);
    });
  } catch (error) {
    console.error("Error loading events:", error);
  }
};

export const handleRegistration = async (event) => {
    event.preventDefault();
    console.log("Submit triggered");

  const eventId = parseInt(document.getElementById("eventId").value);
  const name = document.getElementById("participantName").value;
  const email = document.getElementById("email").value;
  const phone = document.getElementById("phone").value;

  const newRegistration = new Registration(
    Date.now(),
    eventId,
    name,
    email,
    phone
  );

  const validation = newRegistration.validate();
  if (!validation.isValid) {
    showNotification(validation.message);
    return;
  }

  try {
    const eventData = await getEventById(eventId);

    const today = new Date();
    today.setHours(0, 0, 0, 0);
    const eventDate = new Date(eventData.date);
    eventDate.setHours(0, 0, 0, 0);

    if (eventDate < today) {
      showNotification("Registration closed. Event already completed.");
      return;
    }

    if (eventData.availableSeats <= 0) {
      showNotification("No seats available!");
      return;
    }

    await addRegistration(newRegistration);

    eventData.availableSeats -= 1;
    await updateEvent(eventId, eventData);

    showNotification("Registration successful!");

    setTimeout(() => {
      window.location.href = "register.html";
    }, 6000);
  } catch (error) {
    showNotification("Error during registration.");
  }
};