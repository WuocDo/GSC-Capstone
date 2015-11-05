using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShowControls.DO
{
    class QuestionDO
    {
        String question_Name;
        String question_ID;
        List<string> answer;

        public List<string> Answer
        {
            get { return answer; }
            set { answer = value; }
        }

        public QuestionDO()
        { }

        public QuestionDO(String pQuestion_Name, String pQuestion_ID)
        {
            question_Name = pQuestion_Name;
            question_ID = pQuestion_ID;
        }
        public String Question_ID
        {
            get { return question_ID; }
            set { question_ID = value; }
        }

        public String Question_Name
        {
            get { return question_Name; }
            set { question_Name = value; }
        }
    }
}
