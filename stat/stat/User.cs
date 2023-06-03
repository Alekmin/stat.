using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stat_
{
   
    
        public class User
        {
            private List<int> score = new List<int>();
            public User(string login, string password, string age)
            {
                this.Login = login;
                this.Password = password;
                this.Age = age;
            }

            public string Login { get; private set; }
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
