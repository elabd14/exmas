

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam.Exams
{
    internal class PracticalExam : Exam
    {
        public PracticalExam(DateTime examTime, int numberOfQuestions)
         : base(examTime, numberOfQuestions) { }

        public override void ShowExam()
        {
            Console.WriteLine("Final Exam:");
            foreach (var question in Questions)
            {
                question.ShowQuestion();
                foreach (var answer in question.AnswerList)
                {
                    Console.WriteLine(answer);
                }
            }

            int score = CalculateGrade();

        }
        private int CalculateGrade()
        {
            int correctAnswers = 0;
            foreach (var question in Questions)
            {
                Console.WriteLine($"For question '{question.Header}', enter your answer ID:");
                int userAnswerId = int.Parse(Console.ReadLine());

                if (question.RightAnswer != null && userAnswerId == question.RightAnswer.AnswerId)
                {
                    correctAnswers++;
                }
            }
            return correctAnswers;
        }
        public override void ShowAnswers()
        {
            Console.WriteLine("Showing right answers for the Practical Exam:");
            foreach (var question in Questions)
            {
                Console.WriteLine(question.Header);
                Console.WriteLine(question.Body);
                foreach (var answer in question.AnswerList)
                {
                    if (answer == question.RightAnswer)
                    {
                        Console.WriteLine($"Correct Answer: {answer}");
                    }
                }
            }
        }

    }
}
 