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
