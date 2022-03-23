# Project 1 - Store App RESTful API - Nicolas Colorado

## Overview

This project inlcuded creating a RESTful API using ASP.NET framework and deploying it as a store web app. Customers can use the app to register to the database,
update their personal information, and purchase products from multiple stores. Managers can also use the app for their services, such as replenish inventory. Utlizing 
CI/CD so that the project could automatically build, test, and deploy as a web service.

## Technologies Used

* .NET 6.0 
* C#
* xUnit Testing
* XML
* Moq
* Serilog
* ASP.NET Core Web API
* OpenAPI/Swagger
* ADO.NET
* Git
* SQL - Sql Server
* DBeaver
* Azure Cloud Services - SQL Databases 
* SonarQube
* REST
* DevOps

## Functionalities

Features:
* Adds a new customer
* Searches for a customer by name or email
* Places orders to store locations for customers
  - The customer is able to purchase multiple items with one order
* Views order history of customer or store
* Allows customers and managers to view store's inventory
* Verify customer/manager credentials
* Allows only the manager to replenish store's inventory

Future Development:
* Add JWT Authentication for manager credentials

## Usage

Clone the repo on VSCode using the repo's URL: 'https://github.com/220118-Reston-NET/Nicolas-Colorado-P1'

Use the 'cd' command to navigate into the projects API folder (ShopAPI) and run the CLI command: 'dotnet run'

Test the project in a local host provided by the terminal: http://localhost:{yourport}/swagger/index.html

To run tests, 'cd' into the project's test folder (ShopTest) and run the CLI command: 'dotnet test'

## Links

This project uses API Base URL: 'https://p1shopapp.azurewebsites.net'

To utilize Swagger for performing and displaying project's functionalities, use proper API endpoints. For example, to use the "get all customers" functionality and display in on a webpage, the complete URL will be: 'https://p1shopapp.azurewebsites.net/api/Customer/GetAllCustomer' 
