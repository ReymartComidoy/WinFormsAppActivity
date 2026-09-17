SOLID principle solved in this specific project

Single Responsibility Principle (SRP)
-the problem is form1.cs is handling logic, database connections, print commands and total calculations simultaneously. Solution is the
 task were divided into specialized classes like OrderCalculator, SqlOrderRepository and SmtpEmailService

Open/Closed Principle (OCP)
-the problem is adding a new discount type required editing existing if/else logic in btnCalculate_Click and the solution is i
 created IDiscountStrategy to separate discount logic from core calculations

Liskov Substitution Principle (LSP)
-the problem is the system crashed when using FreeShippingDiscount because it threw an exception instead of calculating a price. The
 solution, cleaned up the discount classes so every strategy follows the same rule, allowing any discount to be passed in safely 
 without breaking the program.

Interface Segregation Principle (ISP)
-the problem is when combining print and email functionality into a single monolithic service contract forces classes to implement 
 unused operations. The solution is create interfaces IEmailService and IPrinterService, giving classes access only to the capabilities they need.

Dependency Inversion Principle (DIP)
-the problem is Form1 directly instantiated concrete types SqlConnection, SmtpClient, preventing unit testing without actual database or network 
 side effects. Solution is high-level form logic now relies on abstractions IOrderRepository, IEmailService, allowing implementations to be 
 swapped seamlessly.
