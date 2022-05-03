using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentform
{
    public class Client
    {
        public string firstname { get; set; }
        public string secondname { get; set; }
        public string id { get; set; }

        public Client(string firstname,
                      string secondname,
                      string id)
        {
            this.firstname  = firstname;
            this.secondname = secondname;
            this.id         = id;
        }
        public override string ToString()
        {
            string Output = String.Format("Student added. {0} {1}, ID: {2}",firstname,secondname,id);
            return Output;

        }

    }
}
