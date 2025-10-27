# Sistema de Gestión - Protectora de Animales

## Descripción
Este sistema permite gestionar de manera integral las operaciones de una protectora de animales. 
Centraliza la información de animales, usuarios, solicitudes de adopción y donaciones, 
ofreciendo una plataforma para mejorar la transparencia, la eficiencia y el seguimiento de cada caso.

## Funcionalidades
- Gestión de Animales: registro, edición y baja; control de estados (disponible, adoptado, en tránsito, en tratamiento).
- Gestión de Usuarios: roles diferenciados (Administrador, Voluntario, Tránsito, Adoptante).
- Adopciones: administración completa del proceso (solicitudes, entrevistas, aprobación, seguimiento).
- Tránsitos y Seguimientos: registro de hogares temporales y observaciones post-adopción.
- Donaciones: carga y control de aportes voluntarios.
- Reportes: generación de informes en PDF sobre adopciones, animales y estadísticas.

## Arquitectura
El sistema está diseñado bajo una arquitectura en capas:

- Domain: entidades, reglas de negocio y contratos.
- Application/Services: lógica de aplicación y casos de uso.
- Infrastructure.Data: persistencia con Entity Framework Core.
- DTOs: transferencia de datos entre capas.
- Reports: microservicio con FastReport OSS para generación de reportes PDF.
- Seguridad: autenticación y autorización basada en JWT (JSON Web Tokens).

## Tecnologías Utilizadas
- .NET 8 / C#
- Entity Framework Core (SQL Server)
- Blazor WebAssembly + MudBlazor (frontend web)
- WinForms (aplicación de escritorio administrativa)
- FastReport OSS (reportes)
- JWT para autenticación
- Arquitectura por capas y microservicio de reportes

## Integrantes
- [Esteves Ignacio](https://github.com/NachitoE)  
- [Stella Camila](https://github.com/mimistella)
- [Salerno Nicolás](https://github.com/phalanxeyes) 

## Aviso
Este sistema fue desarrollado como trabajo práctico para la Facultad Regional Rosario - UTN.


---
# Animal Shelter Management System

## Description
This system provides a complete solution to manage the operations of an animal shelter. 
It centralizes information about animals, users, adoption requests, and donations, 
improving transparency, efficiency, and case tracking.

## Features
- Animal Management: register, edit and remove; status control (available, adopted, in foster care, under treatment).
- User Management: differentiated roles (Administrator, Volunteer, Foster, Adopter).
- Adoptions: complete process management (requests, interviews, approval, follow-up).
- Foster and Follow-ups: record temporary homes and post-adoption observations.
- Donations: record and control voluntary contributions.
- Reports: generate PDF reports about adoptions, animals, and statistics.

## Architecture
The system follows a layered architecture:

- Domain: entities, business rules, and contracts.
- Application/Services: application logic and use cases.
- Infrastructure.Data: persistence with Entity Framework Core.
- DTOs: data transfer objects across layers.
- Reports: microservice with FastReport OSS for PDF reports generation.
- Security: authentication and authorization with JWT (JSON Web Tokens).

## Technologies Used
- .NET 8 / C#
- Entity Framework Core (SQL Server)
- Blazor WebAssembly + MudBlazor (web frontend)
- WinForms (desktop administration app)
- FastReport OSS (reporting)
- JWT for authentication
- Layered architecture and reporting microservice

## Authors
- [Esteves Ignacio](https://github.com/NachitoE)  
- [Stella Camila](https://github.com/mimistella)
- [Salerno Nicolás](https://github.com/phalanxeyes) 



## Notice
This system was developed as a coursework project for the Facultad Regional Rosario - UTN.
