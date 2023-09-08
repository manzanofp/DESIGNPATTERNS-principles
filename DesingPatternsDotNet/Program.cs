using DesingPatternsDotNet.Prototype;

Customer customer1 = new Customer() { Name = "Customer 1" };
Customer customer2 = customer1;

customer2.Name = "Customer 2";

Console.WriteLine($"Customer 1:{ customer1.Name }");
Console.WriteLine($"Customer 2:{customer2.Name}");

Console.Read();