namespace OpenClose
{
    public class EmployeeFullTime : IEmployee
    {
        public EmployeeFullTime(string fullname, int hoursWorked)
        {
            Fullname = fullname;
            HoursWorked = hoursWorked;
        }  

        public string Fullname { get; set; }
        public int HoursWorked { get; set; }
        
        public decimal CalculateSalaryMonthly()
        {
            decimal hourValue = 30000M;
            decimal salary = hourValue * HoursWorked;
            return salary;
        }
    }
}