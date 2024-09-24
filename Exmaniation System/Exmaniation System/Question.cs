using System;

namespace Exmaniation_System;

public abstract class Question
{
    public string Body { get; set; } 
    public int Marks { get; set; }    
    public string Header { get; set; } 

    public int NumberOfQestion{set; get;}


    // public List<Question> Questions{set; get;}
 

    public String[] TypeQuestion { get; set; }

    public Question( string header, int marks, string body,int numofQuestion)
    {
        Header = header;
        Marks = (int)marks;
        Body = body;
        NumberOfQestion = numofQuestion;
        
    }

    public abstract void  DisplayQuestion(Subject subject);
    public abstract bool CheckAnswer(string userAnswer);
    public abstract void DisplayCorrectAnswer();


    
}
