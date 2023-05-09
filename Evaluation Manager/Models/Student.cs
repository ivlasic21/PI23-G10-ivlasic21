using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation_Manager.Models {
    public class Student {
        public int Grade { 
            get; set; 
        }
        public int Id { get; internal set; }
        public string FirstName { get; internal set; }
        public string LastName { get; internal set; }
    }
}
