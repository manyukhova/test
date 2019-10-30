using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Group
    {
        public List<Student> Logistic { get; set; }

        public Group()
        {
            Logistic = new List<Student>();
        }
    }
}
