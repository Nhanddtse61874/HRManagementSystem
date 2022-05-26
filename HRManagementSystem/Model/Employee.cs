using HRManagementSystem.Interface;

namespace HRManagementSystem.Model
{
    public abstract class Employee : Payable
    {
        public string Ssn { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public Employee()
        {

        }

        public abstract void Display();

        public abstract double GetPaymentAmount();
        
    }
}
