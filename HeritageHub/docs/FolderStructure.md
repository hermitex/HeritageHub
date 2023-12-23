# Folder Structure Explanation

Below is an explanation of the key folders within the HeritageHub project:

- **bin:** This folder contains the binary output generated during the build process. It is not typically committed to version control and can be regenerated.

- **docs:** The documentation folder holds all project-related documentation, including this documentation.md file.

- **obj:** The obj folder contains object files generated during compilation. Similar to the bin folder, it is not committed to version control.

- **Properties:** The Properties folder contains project properties and settings.

- **src:** The src folder is the main source code directory, organized by layers.

  - **HeritageHub.Api:**
    - **Controllers:** This folder contains API controllers responsible for handling HTTP requests and responses.
    - **Models:** The Models folder includes Data Transfer Objects (DTOs) and View Models used in the API.

  - **HeritageHub.Application:**
    - **Commands:** The Commands folder holds command handlers responsible for executing actions within the application.
    - **Queries:** The Queries folder contains query handlers responsible for retrieving data from the application.
    - **Services:** The Services folder includes application services providing various functionalities.

  - **HeritageHub.Domain:**
    - **Entities:** This folder contains domain entities representing core business concepts.
    - **Repositories:** The Repositories folder includes interfaces defining contracts for data access.
    - **Services:** The Services folder holds domain services responsible for encapsulating domain logic.

  - **HeritageHub.Infrastructure:**
    - **Data:** The Data folder contains database-related code, such as the database context and migrations.
    - **Repositories:** The Repositories folder includes implementations of repositories.
    - **Services:** The Services folder holds infrastructure services like email and logging.

  - **HeritageHub.Tests:**
    - **HeritageHub.Application.Tests:** This folder contains unit tests for the application layer.
    - **HeritageHub.Domain.Tests:** The Domain.Tests folder includes unit tests for the domain layer.
    - **HeritageHub.Infrastructure.Tests:** The Infrastructure.Tests folder contains unit tests for the infrastructure layer.

- **tests:** The tests folder includes integration tests and end-to-end tests.

- **tools:** The tools folder holds build and deployment scripts for the project.

---

Feel free to customize and expand this explanation based on any additional details or specific conventions you follow in your project.