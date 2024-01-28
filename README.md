## Overview
This project is made with .NET 7, but has support for .NET 8. It is a layered project that uses ASP.NET Core MVC, the repository pattern, and is connected to SQL Server.

## Database:
Thanks to EntityFramework Core, when you run the project, the database is automatically generated with all its tables, fields and a default admin. Before running the project, make sure to add your server name to the connection string within the appsettings.json file.

## External services:
On the one hand, Stripe is used to simulate payments. On the other hand, Facebook and Google are used to authenticate users.
Stripe has public keys to perform the tests, but Facebook and Google require that you have to create additional projects so that the necessary keys can be generated.
If you don't want to go back and forth with the documentation, here are the tutorials that I found useful:
  - Facebook: https://www.youtube.com/watch?v=okAf7GLIAAg
  - Google: https://www.youtube.com/watch?v=0nAOnTUJSGY
  - The logic for payments with Stripe is already created, but you need to create an account and, if you want, track the payment simulation from the dashboard. When you enter the dashboard make sure that you have the account activated in test mode.

## Credits:
This project has been thanks to Professor Bhrugen Patel. His course is here: https://www.udemy.com/course/complete-aspnet-core-21-course/

## Future goals:
  - Use more IdentityUI options.
  - Create an Email Sender.
