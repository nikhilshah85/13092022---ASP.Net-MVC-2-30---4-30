namespace DI_Demo.Models
{    public class Employees
    {
        public int empId { get; set; }
        public string empName { get; set; }
        public string empDesignation { get; set; }
        public double empSalary { get; set; }
        public bool empIsPermenant { get; set; }

        static List<Employees> empListData = new List<Employees>()
        {
            new Employees(){empId =101, empName= "Nikhil",empDesignation="Consultant",empSalary=5000, empIsPermenant=true  },
            new Employees(){empId =102, empName= "Karan",empDesignation="Consultant",empSalary=5000, empIsPermenant=true  },
            new Employees(){empId =103, empName= "Rohan",empDesignation="HR",empSalary=5000, empIsPermenant=false  },
            new Employees(){empId =104, empName= "Mohan",empDesignation="Consultant",empSalary=5000, empIsPermenant=true  },
            new Employees(){empId =105, empName= "Julie",empDesignation="Accounts",empSalary=5000, empIsPermenant=true  },
            new Employees(){empId =106, empName= "Sonal",empDesignation="Consultant",empSalary=5000, empIsPermenant=false  },
            new Employees(){empId =107, empName= "Monal",empDesignation="Consultant",empSalary=5000, empIsPermenant=true  },
        };

        public List<Employees> GetEmployeesList()
        {
            return empListData;
        }

        public Employees GetEmpById(int id)
        {
            var e = (from em in empListData
                     where em.empId == id
                     select em).Single();
            if (e != null)
            {
                return e;
            }
            throw new Exception("Employee Not found");
        }

        public string AddEmployee(Employees emp)
        {
            empListData.Add(emp);
            return "Employee Added Successfully";
        }
    }
}
