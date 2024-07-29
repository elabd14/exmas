using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam.question
{
    internal class True_False : Question
    {
        public True_False(string header, string body, int mark) : base(header, body, mark)
        {
        }



        public override void ShowQuestion()
        {
            Console.WriteLine($"{Header}");
            Console.WriteLine($"{Body}");


        }
    }
}