using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Homewoke_b4
{
    public class Student
    {
        public string id {  get; set; }
        public string name { get; set; }
        public string sex { get; set; }
        public float score { get; set; }
        public string faculty { get; set; }

        public Student(string id, string name, string sex, float score, string faculty)
        {
            this.id = id;
            this.name = name;
            this.sex = sex;
            this.score = score;
            this.faculty = faculty;
        }

        public Student()
        {
        }
    }
}
