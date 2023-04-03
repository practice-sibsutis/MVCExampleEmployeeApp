using System.Collections.Generic;

namespace MVCExampleEmployeeApp.Models
{
    namespace EmployeeApplication.Models
    {
        public class EmployeeData
        {
            public static List<EmployeeViewModel> Employees { get; set; } = new List<EmployeeViewModel>();
        }
    }
}
