using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> NewGroup = new List<Student>
            {
                new Student("Maria","Valova",false,5),
                new Student ("Petr", "Pervii", false,4),
                new Student ("Katrin", "Kabur", false,3)
             };

            Group group = new Group();

            for (int i = 0; i < NewGroup.Count; i++)
            {
                group.Logistic.Add(NewGroup[i]);

                Console.WriteLine(group.Logistic[i].FirstName + " " + group.Logistic[i].LastName);
            }
        }
    }
}
