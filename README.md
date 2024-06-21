## CleanArchitectureDemo
I'm building web api application using .net core 6 , .Net core clean architecture Clean Architecture is really about organizing your code to layers and how these layers interact with each other. Clean architecture making our project lossely coupled .

## Clean Architecture Layers
1- Api layer => holds all Web api controllers , Custom authorization filter , validation filter to handle requests validation. this layer referance "infrastructure layer".

2- Core layer => Maps to the layers that hold the Use Case and Entity concerns and is also where our External Interfaces get defined. These innermost layers contain our domain objects and business rules.

3- Infrastructure layer => layer contain our context , repository , and our third party ,this layer contains the physical implementation of the interfaces defined in our domain layer , and reference the core layer.

4- Service Layer => This additional layer focuses on implementing application-specific services and coordinating business logic. It works closely with the Core Layer's Use Cases and MediatR handlers to execute commands and queries, ensuring effective separation of concerns and promoting maintainability.

## CQRS with MediatR
in my application i'm using cqrs with mediatR to send request from api layer to core layer using "mediator.send()" C => means command and using this with [post,put,delete] methods Q => means query and using this with [get] method

CQRS increase lossley coupling between services , because we don't need to inject each service , we just need handler for service and use mediato to send request to it's handler to handle business logic.

## Components

- CQRS Design Pattern

- Generic(Repository) Design Pattern

- Pagination Schema

- Localizations Of Data And Responses

- Fluent Validations

- Configurations Using Data Annotations

- Configurations using Fluent API

- EndPoints Of Operations

- Allow CORS

- Using Identity

- Added Authentication

- Added JWT Token And SwaggerGen

- Authorizations(Roles,Claims)

- Service Like Send (Email,Upload Image)

- Filters

- Database Operations(Views,Procedures,Functions) Endpoint

- Logs

- Unit Test (XUnit)
