using System;

namespace Exmaniation_System;

public class TrueOrFalseQuestion : Question
{
    
      public string Answer { get; set; }
      int type;
    public TrueOrFalseQuestion(string header, int marks, string body, int numofQuestion, int type, string answer) : base(header, marks, body,numofQuestion)
    {
         type = type;
         Answer = answer;
    }

     public override void DisplayQuestion(Subject subject)
    { 
        Console.WriteLine("==============================================================" );
        Console.WriteLine($"Subject : {subject.SubjectName}");
        Console.WriteLine($"Header: {Header}" );
        Console.WriteLine($"Marks: {Marks}" );
        Console.WriteLine($"Question: {Body}" );
         Console.WriteLine("Options : " );     
         Console.WriteLine("1- True" );
         Console.WriteLine("2- False" );
        //  if (!string.IsNullOrEmpty(Answer))
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

