namespace TestExamCode.Q1
{
    internal class Employee
    {
        string EmployeeName;
        int Age;
        double Salary;

        public Employee(string employeeName, int age, double salary)
        {
            EmployeeName = employeeName;
            Age = age;
            Salary = salary;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Employee: " + EmployeeName + ", Age:" + Age + ", Salary: $" + Salary);
        }
    }
}
