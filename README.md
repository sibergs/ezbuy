EzBuy (Easy Shopping)

Problem/Need: Online retail shopping, whether for food, clothing, or any other type of online product (such as Amazon).

Objective:

To facilitate various types of users to make purchases and have them delivered to their homes, especially for food (some people need Uber to bring their groceries from supermarkets). The system will need to implement a shipping system.

Functional Requirements:

User Registration, Product Registration, Customer Registration, Tenant Registration (Customer = Supermarket, Fashion Stores, Electronics Stores, etc.), multi-tenant strategy. Product sales, GPS location, delivery of the product to the home, use AI to extract user characteristics to implement another functional requirement called the Implementation of a recommendation system based on user preferences. If the tenant is a supermarket, implement a food purchasing management system, where users can register their "monthly food basket," which will also be part of the recommendation system.

Non-functional Requirements:

Performance

The system must process 1,000 transactions per second. The response time for a user request must not exceed 2 seconds.

Security

User authentication must follow the AES-256 encryption standard. The system must be resistant to denial of service attacks.

Usability

The user interface must be intuitive for novice users after 30 minutes of training. The system must be accessible to visually impaired users.

Reliability

The system must have a 99.9% availability rate. The mean time between failures (MTBF) must be at least 10,000 hours.

Maintainability

Software updates should not break more than 10% of existing functionality. The source code must be well-documented, with at least 80% documentation coverage.

Portability

The system must be compatible with major browsers (Chrome, Firefox, Safari). The software must be able to run on Windows, Linux, and macOS operating systems.

Efficiency

The system must utilize a maximum of 50% of the server's processing capacity under normal conditions. Memory resources allocated by the system must be released efficiently after a task is completed.

Technologies to be Used (Front End, Back End, Database):

.NET 8 with EntityFramework and Dapper (EF for writing to the database and Dapper for querying). If in doubt, check the benchmarks between ORMs: Angular, MySQL, Python