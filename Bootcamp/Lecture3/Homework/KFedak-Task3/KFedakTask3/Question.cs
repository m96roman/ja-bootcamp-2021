using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFedakTask3
{
   public class Question
    {
        public string Questions { get; set; }
        public string Answear { get; set; }

        public Question(string questions,string answear) 
        {
            this.Questions = questions;
            this.Answear = answear;
        }
    }
}
