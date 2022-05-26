namespace HRManagementSystem.Model
{
    public class SalariedEmployee : Employee
    {
        public double CommissionRate { get; set; }

        public double GrossSalary { get; set; }

        public double BasicSalary { get; set; }

        public SalariedEmployee(string ssn, string firstName, string lastName, DateTime birthDay, string phone, string email, double commissionRate, double grossSalary, double basicSalary)
        {
            Ssn = ssn;
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDay;
            Phone = phone;
            Email = email;
            CommissionRate = commissionRate;
            GrossSalary = grossSalary;
            BasicSalary = basicSalary;  

        }

        public override void Display()
        =>  Console.Write($@"SSN : {Ssn} , First Name : {FirstName} , Last Name : {LastName} , Birth Day : {BirthDate:dd-MM-yyyy} 
                , Phone : {(string.IsNullOrEmpty(Phone) ? "Phone is empty" : Phone) } , Email : {(string.IsNullOrEmpty(Email) ? "Email is empty" : Email)}
                , Comisssion Rate : {CommissionRate} , GrossSalary : {GrossSalary} , Basic Salary : {BasicSalary}");
       

        public override double GetPaymentAmount()
        => GrossSalary;
    }
}
