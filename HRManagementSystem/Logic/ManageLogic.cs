using HRManagementSystem.Model;

namespace HRManagementSystem.Logic
{
    public class ManageLogic
    {
        public List<Department> departments = new List<Department>();

        public List<Employee> employees = new List<Employee>();

        public void CreateEmployee()
        {
            Console.WriteLine("1.Salary Employee");
            Console.WriteLine("2.Hour Employee");
            int choice = 0;
            while (choice > 0 || choice < 3)
            {
                choice = InputInt("Your choice");
                switch (choice)
                {
                    case 1:
                        CreateSalariedEmployee();
                        break;
                    case 2:
                        CreateHourdEmployee(); break;
                    default: return;
                }
            }
        }

        public void CreateDepartment()
        {
            string name = InputString("Name");
            Department department = new Department(name);
            departments.Add(department);
        }
        private void CreateSalariedEmployee()
        {
            Console.WriteLine("Create Salary Employee");
            var department = 0;
            if (departments.Count is 0)
            {
                Console.WriteLine("Please create department before creating employee");
                return;
            }
            else
            {
                Console.WriteLine("Please choose department to add enw employee");
                for (int i = 0; i < departments.Count; i++)
                {
                    Console.WriteLine($"{i + 1} | Department Name : {departments[i].Name}");
                }
                department = InputInt("Your choice By type NO of Department");
            }

            string ssn = InputString("SSN");
            string firstName = InputString("First Name");
            string lastName = InputString("Last Name");
            string phone = InputPhone("Phone");
            string email = InputEmail("Email");
            int day = InputInt("Day");
            int month = InputInt("Month");
            int year = InputInt("Year");
            DateTime birthDay = new DateTime(year, month, day);
            double commissionRate = InputDouble("Commisstion Rate");
            double grossSalary = InputDouble("Gross Salary");
            double basicSalary = InputDouble("Basic Salary");
            Employee emp = new SalariedEmployee(ssn, firstName, lastName, birthDay, phone, email, commissionRate, grossSalary, basicSalary);
            departments[department - 1].Employees.Add(emp);
            employees.Add(emp);
        }

        private void CreateHourdEmployee()
        {
            Console.WriteLine("Create Hour Employee");
            var department = 0;
            if (departments.Count is 0)
            {
                Console.WriteLine("Please create department before creating employee");
                return;
            }
            else
            {
                Console.WriteLine("Please choose department to add new employee");
                for (int i = 0; i < departments.Count; i++)
                {
                    Console.WriteLine($"{i + 1} | Department Name : {departments[i].Name}");
                    department = InputInt("Your choice By type NO of Department");
                }
            }

            string ssn = InputString("SSN");
            string firstName = InputString("First Name");
            string lastName = InputString("Last Name");
            string phone = InputPhone("Phone");
            string email = InputEmail("Email");
            int day = InputInt("Day");
            int month = InputInt("Month");
            int year = InputInt("Year");
            DateTime birthDay = new DateTime(year, month, day);
            double wage = InputDouble("Wage");
            double workingHours = InputDouble("Working Hours");
            Employee emp = new HourEmployee(ssn, firstName, lastName, birthDay, phone, email, wage, workingHours);
            departments[department - 1].Employees.Add(emp);
            employees.Add(emp);
        }

        public void DisplayEmployee()
        {
            if (employees.Count < 0)
            {
                Console.WriteLine("Dont have any employee !");
                return;
            }
            Console.WriteLine("List of Employee");
            foreach (var item in employees)
            {
                item.Display();
                Console.WriteLine($" , Type of Employee : {item.GetType().Name}");
            }
        }

        public void SearchByDepartment(string filter)
        {
            foreach (var item in departments)
            {
                if (item.Name.Contains(filter))
                {
                    Console.WriteLine($"List employees of Department {item.Name}");
                    foreach (var emp in item.Employees)
                    {
                        emp.Display();
                        Console.WriteLine($" , Type of Employee : {emp.GetType().Name}");
                    }
                }
            }
        }

        public void SearchByName(string filter)
        {
            foreach (var emp in employees)
            {
                if (emp.FirstName.Contains(filter) || emp.LastName.Contains(filter))
                {
                    emp.Display();
                    Console.WriteLine($" , Type of Employee : {emp.GetType().Name}");
                }
            }
        }

        public void DisplayDepartment()
        {
            if (departments.Count < 0)
            {
                Console.WriteLine("Dont have department");
                return;
            }

            for (int i = 0; i < departments.Count; i++)
            {
                Console.WriteLine($"NO : {i + 1} , Name : {departments[i].Name} , Number of employee : {departments[i].Employees.Count}");
            }
        }

        private double InputDouble(string message)
        {
            Console.WriteLine($"Please input {message}");
            double value = 0;
            while (true)
            {
                try
                {
                    value = double.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid Double");
                }
            }
            return value;
        }

        private string InputString(string message)
        {
            Console.WriteLine($"Please input {message}");
            string value = Console.ReadLine();
            return value;
        }

        private int InputInt(string message)
        {
            Console.WriteLine($"Please input {message}");
            int value = 0;
            while (true)
            {
                try
                {
                    value = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid Int");
                }
            }
            return value;
        }

        private string InputPhone(string message)
        {
            Console.WriteLine($"Please input {message}");
            string value = "";

            while (true)
            {
                try
                {
                    value = Console.ReadLine();
                    if (value.Length >= 7)
                    {
                        var result = int.Parse(value);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Phone. Phone must have > 7 integer");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid Phone");
                }
            }
            return value;
        }

        private string InputEmail(string message)
        {
            var value = "";
            while (true)
            {
                value = InputString(message);
                if (value.EndsWith("@gmail.com"))
                    break;
                else Console.WriteLine("Wrong format abc@gmail.com");
            }
            return value.Trim();

        }
    }


}
