# UI Test Automation Assessment
## Overview
This is a simple UI test automation assesment where you will find an automated test that you need to complete for a shopping web application using C# and Selenium. Please fork this repository and send the link to your solution.
## Getting Started
### Requirements
* Visual Studio Code
* .NET
### Visual Studio Code Extensions
Add the following extensions in Visual Studio Code:
* C#
* C# Dev Kit
* .NET Core Test Explorer
### Build/Execute Test Cases
You can build and run the test cases with Visual Studio Code using the *Testing* option in the sidebar. Or you can run them from the *terminal*:
```
$ dotnet test
```
## Tasks
Develop an automated test case for the shopping web application [Swag Labs](https://www.saucedemo.com/) with the following steps:
1. Login with valid credentials
2. Add two items to the shopping cart
3. Go to the shopping cart
4. Check the prices in the cart
5. Click the checkout button
6. Enter user information (first name, last name and zip code)
7. Click the continue button
8. Validate checkout page (price calculations)
9. Click the finish button
10. Confirm that the order has been submitted

**Add your test case in the file: tests/TestUI.cs**

You will find the login test case as an example in the same file. You can refactor, add more files, and use any design pattern for your solution.

---

If you have any questions, let us know and good luck!