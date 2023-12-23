# HeritageHub API Documentation

## Introduction

Welcome to the HeritageHub API documentation. HeritageHub is a powerful family web application designed to connect, organize, and preserve your family history. This API allows developers to interact with HeritageHub programmatically.

## Table of Contents

- [HeritageHub API Documentation](#heritagehub-api-documentation)
  - [Introduction](#introduction)
  - [Table of Contents](#table-of-contents)
  - [Authentication](#authentication)
    - [User Registration](#user-registration)
      - [1. New User Registration Process](#1-new-user-registration-process)
    - [Administrator Approval](#administrator-approval)
      - [2. Administrator Approval](#2-administrator-approval)
    - [Unique Family Links](#unique-family-links)
      - [3. Unique Family Links](#3-unique-family-links)
    - [Registration Requests](#registration-requests)
      - [4. Registration Requests](#4-registration-requests)
    - [Family Member Invitation](#family-member-invitation)
      - [5. Family Member Invitation](#5-family-member-invitation)
  - [Family Linking](#family-linking)
    - [Connecting to Base Ancestors](#connecting-to-base-ancestors)
      - [1. Base Ancestor Connection](#1-base-ancestor-connection)
    - [Adding Family Members](#adding-family-members)
      - [2. Adding Family Members](#2-adding-family-members)
  - [Map View](#map-view)
    - [Locating Family Members](#locating-family-members)
      - [1. Geolocation](#1-geolocation)
  - [Family Events](#family-events)
    - [Event Management](#event-management)
      - [1. End-Year Meetings](#1-end-year-meetings)
      - [2. Marriages and Burials](#2-marriages-and-burials)
  - [Family Projects](#family-projects)
    - [Collaborative Endeavors](#collaborative-endeavors)
      - [1. Business Ventures](#1-business-ventures)
      - [2. Family Contributions](#2-family-contributions)
  - [Family History Section](#family-history-section)
    - [Documenting Heritage](#documenting-heritage)
      - [1. Family Heritage Documentation](#1-family-heritage-documentation)
      - [2. Ancestry Exploration](#2-ancestry-exploration)
  - [Conclusion](#conclusion)

## Authentication

### User Registration

#### 1. New User Registration Process

Endpoint: `POST /api/register`

Request:
```json
{
  "familyName": "Smith",
  "greatestAncestor": "John Smith",
  "contactDetails": {
    "email": "john.smith@example.com",
    "phone": "+123456789"
  },
  "personalDetails": {
    "firstName": "John",
    "lastName": "Smith"
  }
}
```

Response:

```json
{
  "message": "Registration request submitted. Awaiting administrator approval."
}
```

### Administrator Approval

#### 2. Administrator Approval

Endpoint: `PUT /api/approve-registration/{userId}`

Response:

```json
{
  "message": "User registration approved successfully."
}
```

### Unique Family Links

#### 3. Unique Family Links

Endpoint: `GET /api/family-link`

Response:

```json
{
  "familyLink": "https://heritagehub.com/family/unique-link"
}
```

### Registration Requests

#### 4. Registration Requests

Endpoint: `GET /api/registration-requests`

Response:

```json
[
  {
    "userId": "123",
    "familyName": "Doe",
    "greatestAncestor": "Jane Doe",
    "contactDetails": {
      "email": "jane.doe@example.com",
      "phone": "+987654321"
    },
    "personalDetails": {
      "firstName": "Jane",
      "lastName": "Doe"
    }
  },
  // Additional registration requests...
]
```

### Family Member Invitation

#### 5. Family Member Invitation

Endpoint: `POST /api/invite-member`

Request:

```json
{
  "email": "invited.family@example.com"
}
```

Response:

```json
{
  "message": "Invitation sent successfully."
}
```

## Family Linking

### Connecting to Base Ancestors

#### 1. Base Ancestor Connection

Endpoint: `POST /api/connect-to-ancestor`

Request:

```json
{
  "ancestorId": "456"
}
```

Response:

```json
{
  "message": "Connected to base ancestor successfully."
}
```

### Adding Family Members

#### 2. Adding Family Members

Endpoint: `POST /api/add-family-member`

Request:

```json
{
  "relation": "spouse",
  "memberDetails": {
    "firstName": "Alice",
    "lastName": "Smith"
  }
}
```

Response:

```json
{
  "message": "Family member added successfully."
}
```

## Map View

### Locating Family Members

#### 1. Geolocation

Endpoint: `GET /api/locate-family-members`

Response:

```json
[
  {
    "memberId": "789",
    "name": "Bob Smith",
    "location": {
      "latitude": 37.7749,
      "longitude": -122.4194
    }
  },
  // Additional family members...
]
```

## Family Events

### Event Management

#### 1. End-Year Meetings

Endpoint: `POST /api/schedule-end-year-meeting`

Request:

```json
{
  "date": "2023-12-31",
  "location": "Family Home"
}
```

Response:

```json
{
  "message": "End-year meeting scheduled successfully."
}
```

#### 2. Marriages and Burials

Endpoint: `POST /api/record-event`

Request:

```json
{
  "eventType": "marriage",
  "

participants": ["Alice Smith", "Bob Johnson"],
  "date": "2023-06-15"
}
```

Response:

```json
{
  "message": "Marriage recorded successfully."
}
```

## Family Projects

### Collaborative Endeavors

#### 1. Business Ventures

Endpoint: `POST /api/start-business-venture`

Request:

```json
{
  "name": "Smith Family Business",
  "description": "A family-owned business venture."
}
```

Response:

```json
{
  "message": "Business venture started successfully."
}
```

#### 2. Family Contributions

Endpoint: `POST /api/track-contribution`

Request:

```json
{
  "projectId": "789",
  "contributorId": "456",
  "amount": 1000
}
```

Response:

```json
{
  "message": "Contribution tracked successfully."
}
```

## Family History Section

### Documenting Heritage

#### 1. Family Heritage Documentation

Endpoint: `POST /api/document-heritage`

Request:

```json
{
  "content": "Lorem ipsum dolor sit amet, consectetur adipiscing elit. ..."
}
```

Response:

```json
{
  "message": "Family heritage documented successfully."
}
```

#### 2. Ancestry Exploration

Endpoint: `GET /api/explore-ancestry`

Response:

```json
{
  "ancestryTree": {
    // Ancestry tree structure...
  }
}
```

## Conclusion

The HeritageHub API provides a comprehensive set of endpoints to interact with family-related data. If you have any questions or need further assistance, please contact the development team.
