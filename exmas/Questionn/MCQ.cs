
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam.question
{
    internal class Mcq : Question
    {
        public Mcq(string header, string body, int mark) : base(header, body, mark)
        {
        }


        public override void ShowQuestion()
        {
            Console.WriteLine($"{Header}");
            Console.WriteLine($"{Body}");

        }
    }
}