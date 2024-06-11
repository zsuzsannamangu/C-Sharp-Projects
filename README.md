# C# Projects
These are some projects I created using C# and .NET Framework.

## Projects

### [TwentyOne game](https://github.com/zsuzsannamangu/TTA-C-Sharp-Projects/tree/main/TwentyOneGame)
This is a fully functional Blackjack or Twenty One Game, but without front-end code. It also has a log built-in that records all cards that were dealt, with a timestamp. Any error message will be recorded to a database. For example, if the user enters other than a whole, positive number for their bet, an error message will be thrown, which will be recorded in the database. Once the user finishes the game, they are asked whether they want to play again. It even has functionality for calculating Aces which can be 1 or 11 according to the user's choice.

### [Newsletter subscription](https://github.com/zsuzsannamangu/TTA-C-Sharp-Projects/tree/main/NewsletterAppMVC)
This application was built with MVC (.NET Framework). It allows users to sign up or unsubscribe from a newsletter. All user information is recorded into a database using Entity Framework. Once users unsubscribe from the newsletter, their name won't appear in the database anymore. However, their information won't be deleted, and there will be a timestamp indicating the date they unsubscribed.

### [Car insurance quote calculator](https://github.com/zsuzsannamangu/TTA-C-Sharp-Projects/tree/main/CarInsurance)
This project is an MVC web application that mimics a car insurance website. This application was built with ASP.NET MVC Entity Framework (.NET Framework). Users are able to enter information about their car, whether they had a DUI or speeding tickets and whether they want full coverage. All this information is saved in the database and can be seen. Every time a user creates their profile, the quote is automatically calculated with business logic and displayed to the user. There is an admin page as well, where administrators can see all customer's name, email address and their associated quote.

## Installation

To run these projects locally, follow these steps:

1. **Clone the repository:**
    ```bash
    git clone https://github.com/zsuzsannamangu/C-Sharp-Projects.git
    ```

2. **Navigate to the project directory:**
    ```bash
    cd your-repo
    ```

3. **Open the project in Visual Studio:**
    - Open Visual Studio
    - Go to `File` > `Open` > `Project/Solution...`
    - Navigate to the project directory and select the `.sln` file.

4. **Restore the dependencies:**
    - In Visual Studio, go to `Tools` > `NuGet Package Manager` > `Manage NuGet Packages for Solution...`
    - Click on `Restore` to install all required packages.

5. **Build the project:**
    - In Visual Studio, go to `Build` > `Build Solution` or press `Ctrl+Shift+B`.

## Usage

### Running the Projects

1. **ASP.NET MVC/Web API Projects:**
    - Open the project in Visual Studio.
    - Press `F5` or click on `IIS Express` to run the web application or API.
    - Open your browser and navigate to the provided URL (e.g., `http://localhost:5000`).

2. **Console Applications:**
    - Open the project in Visual Studio.
    - Press `F5` to run the console application.

3. **Windows Forms/WPF Applications:**
    - Open the project in Visual Studio.
    - Press `F5` to run the desktop application.

## Technologies used
_C#, .NET Framework, MVC, Entity Framework, Visual Studio as IDE, virtual PC inside of Mac with Parallel Desktop_

### Note
Visual Studio for Mac does not work well. It is recommended that you use Visual Studio only on Windows. If you have a Mac, you can create a virtual PC inside of your Mac using [Parallels Desktop](https://www.parallels.com/).

## Author
Zsuzsanna Mangu, zsuzsannamangu@gmail.com

