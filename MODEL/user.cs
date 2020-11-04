using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class user
    {
        private string id;

        public string Id { get => id; set => id = value; }
        private string name;
        public string Name { get => name; set => name = value; }
        private string info;
        public string Info { get => info; set => info = value; }
        private DateTime? dateofbirth;
        public DateTime? Dateofbirth { get => dateofbirth; set => dateofbirth = value; }
        private bool? sex;
        public bool? Sex { get => sex; set => sex = value; }
        public user()
        {
            

        }
        public user(string id, string name, DateTime? dob, string info, bool? sex)
        {
            this.id = id;
            this.name = name;
            this.info = info;
            this.dateofbirth = dob;
            this.sex = sex;

        }
    }
}
