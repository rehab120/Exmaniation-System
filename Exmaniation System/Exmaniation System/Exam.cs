
using System;
using System.Collections.Generic;

namespace Exmaniation_System
{
    public class Exam
    {
        public int NumberOfQuestions { get; set; }
        public List<Question> Questions { get; set; } = new List<Question>();
        public Subject Subject { get; set; }

        public Exam()
        {
            
        }
        public Exam(int numberOfQuestions, Subject subject)
        {
            NumberOfQuestions = numberOfQuestions;
            Subject = subject;
        }

        public void AddQuestion(Question question)
        {
            if (Questions.Count < NumberOfQuestions)
            {
                Questions.Add(question);
            }
            else
            {
                Console.WriteLine("Cannot add more questions, the limit has been reached.");
            }
        }

        public void ShowCorrectAnswers()
        {
            Console.WriteLine("Correct Answers for the Exam:");
            foreach (var question in Questions)
            {

                question.DisplayCorrectAnswer();
                Console.WriteLine("==================================================");


            }
        }

        // public int CalcMark()
        // {
        //     int sum = 0;
        //     foreach (var question in Questions)
        //     {
        //         sum += question.Marks;
        //     }
        //     return sum;
        // }
    }
}
