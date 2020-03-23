using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Csharp_Delegate_Event
{
    delegate bool ScoreCompare(int n);
    class Score
    {
        private int PassScore;

        public Score()
        {
            //Default
        }

        public Score(int PassScore)
        {
            this.PassScore = PassScore;
        }

        public int PASS_SCORE
        {
            get; set;
        }

        public bool PassStudent(int score)
        {
            if (score >= PassScore)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool FailStudent(int score)
        {
            if (score < PassScore)
                return true;
            else
                return false;
        }

        public void GetRequiedScore(Dictionary<string, Student> ss, ScoreCompare sc)
        {
            List<string> KeyList = new List<string>(ss.Keys);
            for (int i = 0; i < KeyList.Count; i++)
            {
                bool result = sc(ss[KeyList[i]].Score);

                if (result)
                {
                    Console.WriteLine($"ID : {ss[KeyList[i]].Id}, Score : {ss[KeyList[i]].Score}");
                }
            }
        }
    }
}
