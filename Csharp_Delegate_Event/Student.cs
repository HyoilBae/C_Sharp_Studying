using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Delegate_Event
{
    class Student
    {
        private string id;
        private int score;

        public Student(string id, int score)
        {
            this.id = id;
            this.score = score;
        }

        public string Id
        {
            get { return id; }
        }

        public int Score
        {
            get { return score; }
        }
    }
}
