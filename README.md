# Course Sign up
Course Sign up System

# Architectural overview
•	Layered Architecture

•	Command Query responsibility segregation(CQRS) with MediatR

•	Domain-driven design

# Explanation of solutions for both parts
•	API to Sign up: API will accept the request and dispatch the message to the corresponding Handler. Handler validates the input with the help of validator and response with validation result if validation failed. If validated, handler passes the details to Course Service to signup and it will be background jobs by hangfire and the user will be notified immediately that request accepted and will notify later. 

•	Course Service will register the student in the course and update statistical data i.e. minimumAge, maximumAge etc. (Notification service not implemented, this will be once improvement)

•	API to Create Course: API will accept the request and dispatch the message to the corresponding Handler (not implemented)

•	API to Create Lecturer: API will accept the request and dispatch the message to the corresponding Handler (not implemented)

•	API to get statistical data through course service. 

•	Unit testing not done yet

# Test strategy for this solution (what to test)
•	Test Application layer handler logic (not done) 

•	Test Domain layer (not done)

# What tools and technologies you used (libraries, framework, tools, storage types, cloud platform features)
•	ASP.NET Core Web API 3.1

•	Entity Framework Core 3.1

•	.NET Core Native DI

•	MediatR - as a request dispatcher to make controllers’ actions simpler 

•	NSwag for API Documentation

•	FluentValidation - to validate command/query request model

•	Hangfire - to execute background process

•	Serilog - for logging

•	xUnit for unit testing

•	NSubstitute for mocking

# What you think that it can be improved and how
•	Apply more DDD concepts

•	Replace hangfire with Azure Web jobs or Functions

•	Create a separate worker process (console app) to process sign-up

•	RabbitMQ or other messaging and Queuing tools can be used. 

•	Validation for capacity while sign up can be done in the validator. 

•	PipelineBehaviour can be added to avoid calling validator from handler

•	BaseController to initialize and inject mediatr, dispatch the message to hander, validation of incoming request, exception handling, etc.

•	Improvement in exception handling 

•	Improvement in logging 

•	Complete implementation of other API endpoints (Creat Course, Create Lecturer, etc)

•	80-90% code coverage can be done (unit testing)
