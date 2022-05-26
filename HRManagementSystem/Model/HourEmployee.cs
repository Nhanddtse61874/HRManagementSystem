namespace HRManagementSystem.Model
{
    public class HourEmployee : Employee
    {
        public double Wage { get; set; }

        public double WorkingHours { get; set; }

        public HourEmployee(string ssn, string firstName, string lastName, DateTime birthDay, string phone, string email, double wage, double workinghours)
        {
            Ssn = ssn;
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDay;
            Phone = phone;
            Email = email;
            Wage = wage;
            WorkingHours = workinghours;
        }

        public override void Display()
       => Console.Write($@"SSN : {Ssn} , First Name : {FirstName} , Last Name : {LastName} , Birth Day : {BirthDate:dd-MM-yyyy} 
                , Phone : {(string.IsNullOrEmpty(Phone) ? "Phone is empty" : Phone) } , Email : {(string.IsNullOrEmpty(Email) ? "Email is empty" : Email)}
                , Wage : {Wage} , WorkingHours : {WorkingHours} ");


        public override double GetPaymentAmount()
       => Wage * WorkingHours;
    }
}
