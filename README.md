# MyFinance

## MyFinance is a web application developed for learning purposes.

## Technologies Used

.NET Core 3.1
Entity Framework Core
ASP.NET Core MVC
HTML
CSS

## Architecture

The project follows a structured architecture consisting of the following components:

- **MyFinance.Domain**: Contains entity classes representing various aspects of the hypermarket domain.
- **MyFinance.Service**: Implements business logic for handling operations within the hypermarket.
- **MyFinance.Data**: Provides data access capabilities and includes the database context for interacting with the underlying database.
- **MyFinance.Web**: The ASP.NET MVC application serving as the front-end for users to interact with the hypermarket system.

## Setting up the Solution

1. Create a solution named "MyFinance" encompassing the aforementioned projects.
2. Configure project references to ensure proper dependencies between components.

## Entities and Context Implementation

### Entities

- Implement entity classes representing categories, providers, and products, including inheritance and navigation properties.

### Context

- Set up the database context class (MyFinanceContext) in the MyFinance.Data project, inheriting from DbContext.
- Define DbSet properties for entities to enable interaction with the database.

## Scaffold a Controller

- Scaffold controllers with views using Entity Framework in the MyFinance.Web project.
- Utilize the MyFinanceContext for data access operations within controllers.

## Running the Application

1. Set MyFinance.Web as the start-up project.
2. Build and run the application to access the hypermarket management system.
3. Explore the functionalities provided for managing categories, providers, products, and more.

## Database Exploration

- Access the database file (.mdf) located in the App_Data folder of the MyFinance.Web project to inspect the data persisted by the application.

## Conclusion

MyFinance offers a robust solution for managing hypermarket operations, featuring a well-structured architecture, entity modeling, data access, and user interface components. Feel free to explore and enhance the application as per your requirements.

Thank you for taking the time to read the MyFinance project's README. We hope you find this application useful. If you have any feedback or suggestions, please don't hesitate to let us know. Happy coding!
