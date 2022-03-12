using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewQuestionsWebApp.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string IntQuestion { get; set; }
        public string IntAnswer { get; set; }

        public Question() //Constructor
        {

        }
    }
}
