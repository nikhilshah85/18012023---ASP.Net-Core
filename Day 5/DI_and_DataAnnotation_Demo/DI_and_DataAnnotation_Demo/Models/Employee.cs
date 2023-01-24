namespace DI_and_DataAnnotation_Demo.Models
{
    public class Employee
    {
        public int empNo { get; set; }
        public string empName { get; set; }
        public double empSalary { get; set; }
        public string empDesignation { get; set; }
        public bool empIsPermenant { get; set; }


        static List<Employee> empList = new List<Employee>()
        {
            new Employee(){ empNo=101, empName="Sumit", empDesignation="Sales", empIsPermenant=true, empSalary=12000},
            new Employee(){ empNo=102, empName="Sumit", empDesignation="Sales", empIsPermenant=true, empSalary=12000},
            new Employee(){ empNo=103, empName="Sumit", empDesignation="Sales", empIsPermenant=true, empSalary=12000},
            new Employee(){ empNo=104, empName="Sumit", empDesignation="Sales", empIsPermenant=true, empSalary=12000},
            new Employee(){ empNo=105, empName="Sumit", empDesignation="Sales", empIsPermenant=true, empSalary=12000},
            new Employee(){ empNo=106, empName="Sumit", empDesignation="Sales", empIsPermenant=true, empSalary=12000},
        };

        public List<Employee> GetAllEmployees()
        {
            return empList;
        }
    }
}
