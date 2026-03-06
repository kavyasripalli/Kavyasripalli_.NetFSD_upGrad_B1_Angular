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

<img width="1366" height="768" alt="Screenshot (20)" src="https://github.com/user-attachments/assets/0500e582-845e-48d9-95cb-969c7656679b" />


- Update existing events

<img width="1366" height="768" alt="Screenshot (24)" src="https://github.com/user-attachments/assets/aad85c6a-96ec-4932-980e-ff3d2d9f80f5" />


- Delete events

<img width="1366" height="768" alt="Screenshot (21)" src="https://github.com/user-attachments/assets/8af4582b-ea9d-43e5-be7c-ed9321dd17e0" />

<img width="1366" height="768" alt="Screenshot (22)" src="https://github.com/user-attachments/assets/67f61b1e-8428-4397-80b8-58ae5ff3be05" />


- View all events

<img width="1366" height="768" alt="Screenshot (13)" src="https://github.com/user-attachments/assets/fb02a28a-baf6-404f-9656-fc1421cda9ba" />


- View number of registrations per event

<img width="1366" height="768" alt="Screenshot (14)" src="https://github.com/user-attachments/assets/457c196c-2ddc-4574-b9ce-d89766d7cd30" />


### User Features
- View available events

<img width="1366" height="768" alt="Screenshot (25)" src="https://github.com/user-attachments/assets/904a2d2a-e96d-43e6-8b06-302d430c69d5" />

- Register for an event

<img width="1366" height="768" alt="Screenshot (29)" src="https://github.com/user-attachments/assets/ed669b60-0fc8-4ee3-bcb9-8f1a35f4268c" />


- Seat availability validation
- Prevent registration if event is full

  <img width="1366" height="768" alt="Screenshot (30)" src="https://github.com/user-attachments/assets/353a7bfc-b1b3-4cb3-81d8-7ae79c2258ab" />



## Implemented

- Available seats decrease after registration
- Registration cannot exceed event capacity
- Past events cannot be registered
- Events with registrations cannot be deleted

  
<img width="1366" height="768" alt="Screenshot (31)" src="https://github.com/user-attachments/assets/2869226c-de4b-4b68-b3de-b90407744aeb" />


## How to Run the Project

1. Install JSON Server "npm install -g json-server"

2. Start JSON Server "json-server --watch db.json"

3. Open the project using Live Server.

4. Open "index.html" to manage events.

5. Open "Register.html" to register for event
