# EventSphere – Event Management System

## Project Overview
EventSphere is a frontend Event Management Application that allows administrators to manage events and users to register for events.

The system is built using JavaScript with modular architecture and uses JSON Server as a fake REST API.

## Technologies Used

- HTML5
- CSS3
- JavaScript (ES6+)
- ES6 Modules
- JSON Server (Fake REST API)

## Features

### Admin Features
- Add new events
- Update existing events
- Delete events
- View all events
- View number of registrations per event

### User Features
- View available events
- Register for an event
- Seat availability validation
- Prevent registration if event is full

## Implemented

- Available seats decrease after registration
- Registration cannot exceed event capacity
- Past events cannot be registered
- Events with registrations cannot be deleted

## Project Structure

event-management/
│
├── index.html
├── add-event.html
├── register.html
│
├── js/
│ ├── models/
│ ├── services/
│ ├── controllers/
│ ├── utils/
│
└── db.json

## How to Run the Project

1. Install JSON Server "npm install -g json-server"

2. Start JSON Server "json-server --watch db.json"

3. Open the project using Live Server.

4. Open "index.html" to manage events.

5. Open "Register.html" to register for event