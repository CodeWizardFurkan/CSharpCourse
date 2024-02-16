
CustomerManager customerManager = new CustomerManager();
customerManager.Add();
customerManager.Update();

ProductManager productManager = new ProductManager();
productManager.Add();
productManager.Update();

Customer customer = new Customer();
customer.Id = 1;
customer.City = "Ankara";
customer.FirstName = "Furkan";
customer.LastName = "Demir";

Customer customer2 = new Customer
{
    Id = 2,
    City = "İzmir",
    FirstName = "İrem",
    LastName = "Karaca"
};

Console.WriteLine(customer2.FirstName);
