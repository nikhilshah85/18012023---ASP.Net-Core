namespace demo_webAPIService_MVC.Models
{
    public class Employee
    {
        public int empNo { get; set; }
        public string empName { get; set; }
        public double empSalary { get; set; }
        public string empDesignation { get; set; }
        public bool empIsPermenant { get; set; }

        static List<Employee> eList = new List<Employee>()
        {
            new Employee(){ empNo=101, empName="Karan", empDesignation="Sales", empSalary=6000, empIsPermenant=true },
            new Employee(){ empNo=102, empName="Sumit", empDesignation="Accounts", empSalary=8000, empIsPermenant=true },
            new Employee(){ empNo=103, empName="Priya", empDesignation="Sales", empSalary=5000, empIsPermenant=false },
            new Employee(){ empNo=104, empName="Riya", empDesignation="Sales", empSalary=1000, empIsPermenant=true },
            new Employee(){ empNo=105, empName="Jiya", empDesignation="Sales", empSalary=12000, empIsPermenant=true },
            new Employee(){ empNo=106, empName="Diya", empDesignation="Accounts", empSalary=9000, empIsPermenant=false },
        };


        public List<Employee> GetAllEmployees()
        {
            return eList;
        }

        public Employee GetEmployeeById(int eno)
        {
            var emp = eList.Find(e => e.empNo == eno);
            if (emp != null)
            {
                return emp;
            }
            throw new Exception("Employee Not Found");
        }




    }
}
