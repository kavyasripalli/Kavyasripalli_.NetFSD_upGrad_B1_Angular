const BASE_URL = "http://localhost:3000/registrations";

export const getRegistrations = async () => {
  try {
    const response = await fetch(BASE_URL);
    if (!response.ok) throw new Error("Failed to fetch registrations");
    return await response.json();
  } catch (error) {
    console.error("Error fetching registrations:", error);
    throw error;
  }
};

export const addRegistration = async (registrationData) => {
  try {
    const response = await fetch(BASE_URL, {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
      },
      body: JSON.stringify(registrationData),
    });

    if (!response.ok) throw new Error("Failed to register");
    return await response.json();
  } catch (error) {
    console.error("Error adding registration:", error);
    throw error;
  }
};

export const getRegistrationsByEvent = async (eventId) => {
  try {
    const response = await fetch(`${BASE_URL}?eventId=${eventId}`);
    if (!response.ok) throw new Error("Failed to fetch event registrations");
    return await response.json();
  } catch (error) {
    console.error("Error fetching event registrations:", error);
    throw error;
  }
};