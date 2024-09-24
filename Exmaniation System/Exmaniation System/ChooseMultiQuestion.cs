using System;

namespace Exmaniation_System;

public class ChooseMultiQuestion:Question
{
     public string[] Options { get; set; } 
     public string[] Answers { get; set; }
    

    int TYPE;

    public ChooseMultiQuestion(string header, int marks, string body, int numofQuestion, int type, string [] option, string[] answer) : base(header, marks, body, numofQuestion)
    {
        TYPE = type;
         Options = option;
         Answers = answer;
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
            Console.WriteLine("Options: Choose multi answer ");
            for (int i = 0; i < Options.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {Options[i]}");
            }
        }
        
    //    for(int i=0 ; i< Answers.Length;i++){
    //     if (!string.IsNullOrEmpty(Answers[i]))
    //     {
    //         Console.WriteLine($"Correct Answers {i+1} :{Answers[i]}" );
    //     }
    //    }
    }
    public override bool CheckAnswer(string userAnswer)
        {
            // Split user answer by commas for multiple answers
            string[] userAnswers = userAnswer.ToLower().Split(',');
            foreach (string userAns in userAnswers)
            {
                if (!Array.Exists(Answers, answer => answer.ToLower().Trim() == userAns.Trim()))
                {
                    return false;
                }
            }
            return true;
        }
    public override void DisplayCorrectAnswer()
        {
            Console.WriteLine($"Correct Answers: {string.Join(", ", Answers)}");
        }


}
