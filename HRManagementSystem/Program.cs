// See https://aka.ms/new-console-template for more information
using HRManagementSystem.Logic;
using HRManagementSystem.Model;

Department department1 = new Department("Division 1");
Department department2 = new Department("Division 2");
SalariedEmployee employee1 = new SalariedEmployee("SE01", "Truong", "Tan Sang", new DateTime(1996, 1, 1), "0779", "SangTT@gmail.com", 10.9, 2000, 1900);
SalariedEmployee employee2 = new SalariedEmployee("SE02", "Do", "Nhan", new DateTime(1996, 10, 3), "0779", "NhanDDT@gmail.com", 9, 1, 900);
HourEmployee employee3 = new HourEmployee("HE01", "Nguyen", "Bao", new DateTime(1996, 4, 4), "0779", "BaoNC@gmail.com", 9, 10);
int choice = 0;
ManageLogic admin = new ManageLogic();
admin.employees.Add(employee1);
admin.employees.Add(employee2);
admin.employees.Add(employee3);
admin.departments.Add(department1);
admin.departments.Add(department2);
admin.departments[0].Employees.Add(employee1);
admin.departments[0].Employees.Add(employee2);
admin.departments[1].Employees.Add(employee3);
while (choice != 6)
{
    Console.WriteLine("1.Create employee from keyboard");
    Console.WriteLine("2.Create Department");
    Console.WriteLine("3.Display employees");
    Console.WriteLine("4.Search by departments");
    Console.WriteLine("5.Search by name");
    Console.WriteLine("6.Exit");

    Console.WriteLine("Please Input your choice : ");
    try
    {
        choice = int.Parse(Console.ReadLine());
    }
    catch (Exception)
    {
        Console.WriteLine("Invalid Value");
    }
    switch (choice)
    {
        case 1: admin.CreateEmployee(); break;
        case 2: admin.CreateDepartment(); break;
        case 3: admin.DisplayEmployee(); break;
        case 4:
                Console.WriteLine("Input your keyword : ");
                var value = Console.ReadLine(); 
                admin.SearchByDepartment(value);
                break;
        case 5:
                var value1 = Console.ReadLine();
                admin.SearchByName(value1);
                break;
        default:
            Console.WriteLine("See you again");
            return;
    }
}