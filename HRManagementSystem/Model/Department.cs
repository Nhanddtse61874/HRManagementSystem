namespace HRManagementSystem.Model
{
    public class Department
    {
        public string Name { get; set; }

        public List<Employee> Employees { get; set; } = new List<Employee>();

        public Department(string name)
        {
            Name = name;
        }
        public void Display()
        {
            Console.WriteLine("List of Employee");
            foreach (var employee in Employees)
            {
                employee.Display();
            }
        }
    }
}
