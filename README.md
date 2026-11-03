# IKEDC Prepaid Meter Purchase API

### A C# and ASP.NET Web Application for Prepaid Electricity Meter Transactions

![C#](https://img.shields.io/badge/C%23-Programming-purple)
![ASP.NET](https://img.shields.io/badge/ASP.NET-Backend-blue)
![API](https://img.shields.io/badge/REST-API-green)
![HTML](https://img.shields.io/badge/HTML-Frontend-orange)
![Status](https://img.shields.io/badge/Project-Academic%20Project-informational)

---

## 1. Project Overview

The IKEDC Prepaid Meter Purchase API is a web-based application developed using C# and ASP.NET to explore backend application development, API creation, and frontend/backend integration.

The project focuses on developing a prepaid electricity meter purchase system that collects customer and meter information, processes purchase-related requests, and connects a frontend interface with backend application functionality.

The application was developed as part of my software development training during my Students Industrial Work Experience Scheme (SIWES) at ARM Holding Company.

The project provided practical exposure to building backend functionality with C#, structuring an ASP.NET application, creating API endpoints, handling HTTP requests, and integrating a web interface with backend services.

It also introduced me to the fundamentals of API communication and how different application components exchange information.

The application was designed around a Meter Purchase Portal, where users could interact with a frontend interface and submit meter-related information for processing.

## 2. Project Objectives

The primary objectives of this project were:

- To develop a web-based prepaid electricity meter purchase application.
- To understand backend development using C# and ASP.NET.
- To explore the development of API endpoints.
- To understand how HTTP GET and POST requests work.
- To create structured data models for handling meter information.
- To connect a frontend interface with backend application functionality.
- To understand Cross-Origin Resource Sharing (CORS) and its role in web application communication.
- To gain practical experience with API request handling and response processing.
- To understand how backend services can support real-world utility-related applications.

## 3. Technologies and Tools Used

### C#

C# was the primary programming language used for the backend development of the application.

It was responsible for defining application models, handling backend logic, and implementing the functionality required to process meter-related information.

C# provided the object-oriented programming foundation for organising the application.

Concepts explored include:

- Classes and objects.
- Properties and data types.
- Methods.
- Object-oriented programming.
- Data handling.
- Application logic.
- Backend request processing.

### ASP.NET

ASP.NET was used to develop the backend application and expose functionality through API endpoints.

It provided the framework for handling incoming HTTP requests and returning responses to the frontend.

The backend served as the central processing component of the application.

### HTML

HTML was used to structure the frontend interface.

It provided the elements required to display the Meter Purchase Portal and collect information from users.

### CSS

CSS was used to style and organise the frontend interface.

It helped establish the visual structure and presentation of the portal.

### JavaScript

JavaScript can be used on the frontend to handle user interactions and communicate with backend API endpoints.

Its role in the project should reflect the actual frontend implementation.

### Visual Studio / Visual Studio Code

These development environments were used to write, organise, edit, and manage the application's source code.

---

## 4. Application Architecture

The application follows a frontend/backend architecture in which the user interface communicates with the ASP.NET backend through HTTP requests.

The frontend is responsible for collecting user information and presenting the interface.

The backend handles incoming requests, processes the submitted information, and returns appropriate responses.

A simplified representation of the architecture is:

```text
             USER
               |
               v
       METER PURCHASE PORTAL
               |
               v
        FRONTEND INTERFACE
          HTML / CSS
               |
               v
         HTTP REQUESTS
               |
               v
        ASP.NET BACKEND
               |
               v
         METERCONTROLLER
               |
               v
           METERCLASS
               |
               v
       APPLICATION RESPONSE
               |
               v
        FRONTEND INTERFACE
```

### How the Application Works

**Step 1: User Interaction**

The user accesses the Meter Purchase Portal through the frontend interface.

The interface provides a way to enter the relevant meter and customer information.

**Step 2: Request Submission**

When an operation is submitted, the frontend communicates with the backend through an HTTP request.

The request contains the information required by the relevant API endpoint.

**Step 3: Backend Request Handling**

The ASP.NET backend receives the request and routes it to the appropriate controller action.

In this project, the MeterController is responsible for handling meter-related requests.

**Step 4: Data Processing**

The application uses the MeterClass to represent the meter information being handled.

This provides a structured way of working with the information submitted to the backend.

**Step 5: Response Generation**

The backend processes the request and returns an appropriate HTTP response.

The frontend can then use that response to update the interface or display relevant information.

---

## 5. Backend Development

The backend was developed using C# and ASP.NET.

The main purpose of the backend is to provide the application functionality required by the Meter Purchase Portal.

It handles incoming requests and organises the processing of meter-related information.

### MeterController

The MeterController is one of the central components of the application.

It acts as the interface between incoming HTTP requests and the backend application logic.

The controller was developed to handle meter-related operations through API endpoints.

The project included GET and POST request handling.

**GET Request**

The HTTP GET method is generally used to retrieve information from an application.

Within the context of this project, a GET endpoint can be used to retrieve meter-related information exposed by the backend.

**POST Request**

The HTTP POST method is generally used to submit information to an application for processing or creation.

Within the project, POST request handling was used for submitting meter-related information to the backend.

The controller provides a structured way for the frontend to communicate with the backend without directly accessing its internal application logic.

### MeterClass

The MeterClass represents the data structure used to organise meter-related information.

It defines the properties associated with a meter purchase request.

The documented properties include:

| Property | Description |
|---|---|
| Meter Number | Identifies the electricity meter |
| Customer Name | Represents the customer's name |
| Amount | Represents the intended purchase amount |

The class provides a structured representation of the information used by the application.

Using a dedicated model makes the application easier to organise and allows the backend to work with related information as a single object.

---

## 6. API Development and HTTP Methods

An important part of this project was learning how APIs allow different parts of an application to communicate.

An API, or Application Programming Interface, provides a defined way for one software component to interact with another.

In this application, the ASP.NET backend exposes endpoints that can receive requests from the frontend.

### Understanding HTTP GET

GET is an HTTP method used to request information from a server.

For example, a meter-related GET endpoint could retrieve information already available within the application.

### Understanding HTTP POST

POST is an HTTP method used to submit information to a server.

For example, the frontend could submit a meter number, customer name, and intended purchase amount to the backend.

### API Request and Response Flow

The general process is:

1. The frontend prepares the required information.
2. The frontend sends an HTTP request to the backend.
3. ASP.NET receives the request.
4. The appropriate controller action handles it.
5. The application processes the submitted information.
6. The backend returns an HTTP response.
7. The frontend receives and processes the response.

This project introduced me to the fundamentals of building and consuming APIs within a web application.

---

## 7. Frontend Integration

The application included a frontend interface referred to as the Meter Purchase Portal.

The frontend provides the user-facing component of the application and acts as the point of interaction between the user and the backend.

Its purpose is to make the application's functionality accessible through a web interface.

### Frontend Responsibilities

The frontend is responsible for:

- Presenting the Meter Purchase Portal.
- Providing fields for meter-related information.
- Collecting customer and purchase information.
- Submitting information to backend endpoints.
- Receiving backend responses.
- Displaying relevant information to the user.

### Frontend and Backend Communication

The frontend and backend operate as separate components.

The frontend collects information and sends requests, while the backend receives and processes those requests.

This separation makes it possible to develop the user interface and backend functionality independently while maintaining communication between them.

---

## 8. Cross-Origin Resource Sharing (CORS)

Another important concept explored during the development of this project was Cross-Origin Resource Sharing (CORS).

CORS is a browser security mechanism that controls whether a web application running on one origin can access resources from another origin.

An origin consists of a combination of:

- Protocol.
- Domain or hostname.
- Port number.

For example, a frontend running on one local development port may need to communicate with an ASP.NET backend running on another port.

Because these origins are different, the browser may restrict the request unless the backend provides the appropriate CORS permissions.

### Why CORS Was Relevant

During frontend/backend integration, CORS configuration was relevant because the Meter Purchase Portal needed to communicate with the ASP.NET API.

Understanding CORS helped explain why browser-based requests can be blocked even when the backend endpoint itself is available.

It also introduced the importance of configuring cross-origin permissions appropriately when developing web applications.

---

## 9. Understanding the Application Workflow

The general workflow of the Meter Purchase Portal can be represented as follows:

```text
START
  |
  v
OPEN METER PURCHASE PORTAL
  |
  v
ENTER METER INFORMATION
  |
  v
SUBMIT REQUEST
  |
  v
ASP.NET BACKEND RECEIVES REQUEST
  |
  v
METERCONTROLLER PROCESSES REQUEST
  |
  v
METERCLASS REPRESENTS DATA
  |
  v
BACKEND RETURNS RESPONSE
  |
  v
FRONTEND RECEIVES RESPONSE
  |
  v
DISPLAY RESULT
  |
  v
END
```

This workflow demonstrates the relationship between the frontend, API endpoints, controller, and data model.

It also illustrates how information travels through a web application during a typical request-response cycle.

---

## 10. Development Process

The development process involved exploring how a C# application could be extended from a basic console-based program into a web-based application.

The project provided an opportunity to understand how backend logic could be exposed through an ASP.NET application and accessed through a frontend interface.

The main development activities included:

**Step 1: Understanding the Application Requirements**

Identifying the information required for a prepaid meter purchase portal and determining the data that needed to be represented within the application.

**Step 2: Creating the Meter Data Model**

Developing the MeterClass to represent meter-related information, including meter number, customer name, and purchase amount.

**Step 3: Developing the Backend**

Using C# and ASP.NET to organise the application's backend functionality.

**Step 4: Creating API Endpoints**

Working with the MeterController to expose GET and POST operations for handling meter-related requests.

**Step 5: Developing the Frontend**

Creating the Meter Purchase Portal interface using frontend web technologies.

**Step 6: Configuring CORS**

Exploring cross-origin configuration to allow the frontend and backend to communicate during development.

**Step 7: Integrating Application Components**

Connecting the frontend interface to the ASP.NET backend through HTTP requests.

---

## 11. Project Structure

A typical ASP.NET Core Web API project may follow a structure similar to the example below:

```text
IKEDCMeterPurchasePortal/
│
├── Controllers/
│   └── MeterController.cs
│
├── Models/
│   └── MeterClass.cs
│
├── wwwroot/
│   ├── css/
│   ├── js/
│   └── index.html
│
├── Properties/
│
├── appsettings.json
│
├── Program.cs
│
└── IKEDCMeterPurchasePortal.csproj
```

This is an illustrative structure and may differ from the actual organisation of the project.

### Explanation of the Main Components

**Controllers**

Contains the controller classes responsible for handling incoming API requests.

**Models**

Contains the data models used to represent information within the application.

**wwwroot**

In ASP.NET Core, this directory can contain static frontend files such as HTML, CSS, JavaScript, and images.

**Program.cs**

Contains the application's startup configuration and service registration.

**appsettings.json**

Contains application configuration settings.

**Project File**

The `.csproj` file defines project settings, dependencies, and other build-related information.

---

## 12. Skills and Knowledge Gained

Working on this project provided practical exposure to several important software development concepts.

### C# Backend Development

Improved my understanding of using C# to structure backend application logic and represent information through classes and properties.

### ASP.NET Web Development

Gained experience exploring how ASP.NET can be used to develop web-based backend services.

### API Development

Learned the fundamentals of exposing backend functionality through HTTP endpoints and handling GET and POST requests.

### Frontend/Backend Integration

Developed an understanding of how frontend interfaces communicate with backend services through HTTP requests.

### Data Modelling

Explored how classes such as MeterClass can represent structured information within an application.

### CORS Configuration

Gained exposure to cross-origin communication and the importance of configuring browser access between frontend and backend applications.

### Application Architecture

Developed an understanding of how controllers, models, API endpoints, and user interfaces work together.

---

## 13. Future Improvements

The project provides a foundation that could be expanded into a more comprehensive electricity meter management and purchase platform.

Potential improvements include:

- Integration with an authorised electricity vending provider.
- Actual meter number verification.
- Prepaid and postpaid meter support.
- Secure payment gateway integration.
- Transaction reference generation.
- Purchase history and transaction tracking.
- Improved request validation.
- Error handling and meaningful API responses.
- Database integration for transaction records.
- User authentication and account management.
- Automated API testing.
- API documentation using Swagger/OpenAPI.
- Improved frontend responsiveness.

These are proposed enhancements and should not be confused with features already implemented in the original project.

---

## 14. Project Information

**Project Name:** IKEDC Prepaid Meter Purchase API

**Application Name:** Meter Purchase Portal

**Project Type:** Web Application / Backend API

**Primary Programming Language:** C#

**Backend Framework:** ASP.NET

**Frontend Technologies:** HTML and CSS

**API Methods:** HTTP GET and POST

**Backend Components:** MeterController and MeterClass

**Additional Concepts:** REST API Fundamentals, CORS, Frontend/Backend Integration

**Project Context:** Software Development Training During SIWES at ARM Holding Company

**Project Status:** [Update with actual project status]

---

## 15. Author

**Odetola Oluwatobiloba Toluwanimi**

Computer Science Student | Aspiring Full-Stack Developer

**Technical Interests:**

- C# and ASP.NET Development.
- Backend Web Development.
- REST API Development.
- Frontend/Backend Integration.
- Database Management.
- Full-Stack Application Development.

GitHub: [Your GitHub Profile]

---

## 16. Acknowledgements

This project was developed as part of my software development training during my SIWES at ARM Holding Company.

It provided an opportunity to explore backend development using C# and ASP.NET, understand API communication, and gain practical experience integrating frontend interfaces with backend services.

The project also contributed to my understanding of how web applications are structured and how different components work together to deliver application functionality.

---

*Building, learning, and developing practical software solutions through continuous improvement.*
