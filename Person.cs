using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWin_DIan
{
    internal class Person
    {
        private string name;
        private string secondname;
        private string lastname;
        private string egn;
        private string gender;
        private string job;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Secondname
        {
            get { return secondname; }
            set
            {
                secondname = value;
            }
       }

       public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }

        public string Egn
        {
            get { return egn; }
            set { egn = value; }        
        }
        
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public string Job
        {
            get { return job; }
            set { job = value; }
        }
    }
}
