# NUnit Playwright Project

This project is a .NET application that utilizes NUnit and Playwright for automated testing of web applications. It follows the Page Object Model (POM) design pattern to organize test code and improve maintainability.

## Project Structure

- **Pages/**: Contains page object classes.
  - **BasePage.cs**: Base class for all page objects, providing common properties and methods.
  - **GooglePage.cs**: Page object for Google, including methods to navigate and perform searches.

- **Tests/**: Contains test classes.
  - **GoogleSearchTests.cs**: Test class that includes tests for searching on Google.

- **NUnitPlaywrightProject.csproj**: Project file that defines dependencies and target framework.

## Setup Instructions

1. **Clone the repository**:
   ```
   git clone <repository-url>
   cd NUnitPlaywrightProject
   ```

2. **Install dependencies**:
   Ensure you have the .NET SDK installed. Run the following command to restore the project dependencies:
   ```
   dotnet restore
   ```

3. **Run the tests**:
   To execute the tests, use the following command:
   ```
   dotnet test
   ```

## Test Overview

The project includes a test case that opens Google and searches for "apple". The test is implemented in the `GoogleSearchTests` class and utilizes the `GooglePage` page object for interaction with the Google search page.

## Contributing

Feel free to submit issues or pull requests for improvements or bug fixes.