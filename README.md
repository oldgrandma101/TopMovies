# TopMovies

 TopMovies is a C# web application that was created to share my favourite movies and TV shows so that people can stop wasting time trying to decide what to watch. 
 TopMovies uses a ASP.NET Core framework with a MVC architecture, an Entity Framework for interacting with the MSSQL Server database, a REST API for making calls to the database and C# Razor pages for the views.
 
 This website isn't hosted, to see this site please follow the instructions below.

 Steps to be able to see the website:
  
  1) Downlaod this repository as a ZIP file. Go to the repository oldgrandma101/TopMovies -> click code button -> click download ZIP

  2) In file explorer on your computer right click on the ZIP folder and select extract all

  3) Once extracted, follow the file path TopMovies-Master/TopMovies Master and you should see TopMovies.sln.

  4) Confirm that the latest version of Visual Studio is installed on your computer and then open TopMovies.sln with Visual Studio.

  5) Once Visual Studio is open click the view button -> click other windows -> click package manager console

  6) Wait for PowerShell host to initialize

  7) Type add-migration "initialsetup"  in the package manager console and then press Enter on the keyboard

  8) Type update-database in the package manager concole and then press Enter on the keyboard

  9) Click the arrow pointing down circled in red in the picture below
      ![image](https://github.com/oldgrandma101/TopMovies/assets/115679097/cdc78f65-cf6d-4bfc-a5e2-e1e75e06da21)

10) Select IIS Express from the resulting dropdown menu aftre completing step 9.

11) Click the IIS Express button circlled in red to launch the website that will be hosted locally.
    ![image](https://github.com/oldgrandma101/TopMovies/assets/115679097/94667ed7-48d4-4847-8d3d-07367dfb3708)



  
