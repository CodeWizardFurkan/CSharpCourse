using Interfaces;

ICustomerDal[] customerDals = new ICustomerDal[3]
{
    new SqlServerCustomerDal(), 
    new OracleCustomerDal(),
    new MySqlCustomerDal(),
};

foreach (var customerDal in customerDals)
{
    customerDal.Add();
}

static void InterfacesIntro()
{
    PersonManager personManager = new PersonManager();

    Customer customer1 = new Customer();
    customer1.Id = 2;
    customer1.FirstName = "İrem";
    customer1.LastName = "Karaca";
    customer1.Address = "İzmir";

    Student student1 = new Student
    {
        Id = 1,
        FirstName = "Furkan",
        LastName = "Demir",
        Departmant = "Computer Sciences"
    };


    personManager.Add(student1);
    personManager.Add(customer1);
}

static void Demo()
{
    CustomerManager customerManager = new CustomerManager();
    customerManager.Add(new SqlServerCustomerDal());
}

interface IPerson
{
    int Id { get; set; }
    string FirstName { get; set; }
    string LastName { get; set; }
}

class Customer : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
}

class Worker : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Departmant { get; set; }
}

class Student : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Departmant { get; set; }
}

class PersonManager
{
    public void Add(IPerson person)
    {
        Console.WriteLine(person.FirstName);
    }
}