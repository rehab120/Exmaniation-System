using System;

namespace Exmaniation_System;

public class ChooseOneQuestion:Question
{
      public string[] Options { get; set; } // Array for multiple-choice options (if applicable)
      public string Answer { get; set; }
      int TYPE;

    public ChooseOneQuestion(string header, int marks, string body, int numofQuestion, int type, string [] option, string answer) : base(header, marks, body, numofQuestion)
    {
         TYPE = type;
         Options = option;
         Answer = answer;
    }
     public override void DisplayQuestion(Subject subject)
    {
        Console.WriteLine("==============================================================" );
        Console.WriteLine($"Subject: {subject.SubjectName}");
        Console.WriteLine($"Header: {Header}" );
        Console.WriteLine($"Marks: {Marks}" );
        Console.WriteLine($"Question: {Body}" );
        if (Options.Length > 0)
        {
            Console.WriteLine("Options: Choose one answer");
            for (int i = 0; i < Options.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {Options[i]}");
            }
        }

        // if (!string.IsNullOrEmpty(Answer))
        // {
        //     Console.WriteLine($"Answer :{Answer}" );
        // }  
          }
      public override bool CheckAnswer(string userAnswer)
        {
           
            //return Answer == userAnswer.ToLower();
            if (Answer == userAnswer.ToLower())
            {
                Console.WriteLine($"Correct! You earned {Marks} marks.");
                return true;
            }
            else
            {
                Console.WriteLine("Incorrect.");
                return false;
            }
        }

        public override void DisplayCorrectAnswer()
        {
            Console.WriteLine($"Correct Answer: {Answer}");
        }
}
