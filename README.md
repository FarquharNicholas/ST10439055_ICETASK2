StudentLogInIceTask – Extra Registration Fields
Changes
Added: FirstName, Qualification, Module to user model (Models/UserInformation.cs).

Database: New migration adds these columns to AspNetUsers table.

Pages Updated:

Register form & logic (Areas/Identity/Pages/Account/Register.*)

Login/Logout (Login.*, Logout.*)

Navigation (Views/Shared/_LoginPartial.cshtml)

Profile page (Controllers/HomeController.cs, Views/Home/Profile.cshtml)

How to Test
Run:

bash
Copy
Edit
dotnet run
Go to /Identity/Account/Register → fill in First Name, Qualification, Module.

Login at /Identity/Account/Login.

Click Profile → confirm details show.

Logout to finish.
