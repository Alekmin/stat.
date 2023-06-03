using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stat_
{
   
    
        public class Employee
        {
            private List<int> score = new List<int>();
            public Employee(string name, string surname, string password, string age)
            {
                this.Name = name;
                this.Surname = surname;
                this.Password = password;
                this.Age = age;
            }

            public string Name { get; private set; }
            public string Surname { get; private set; }
            public string Password { get; private set; }
            public string Age { get; private set; }



        public int Resoult
            {
                get
                {
                    return this.score.Sum();
                }
            }

            public void Addscore(int number)
            {
                this.score.Add(number);
            }
        }

    
}
