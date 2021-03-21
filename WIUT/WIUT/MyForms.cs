using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WIUT
{
    class MyForms
    {
        // to see only one form at a time. If the user clicks on the All applicatns the program opens exisiting form (already run). Generic parameters (constraint) 
        public static T GetForm<T>() where T : class, new()
        {
            return Application.OpenForms.OfType<T>().FirstOrDefault() ?? new T();
        }
    }
}
