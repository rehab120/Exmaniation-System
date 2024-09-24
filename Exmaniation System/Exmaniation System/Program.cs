// See https://aka.ms/new-console-template for more information
using Exmaniation_System;

    try{
        int totalMark =0;
        Console.WriteLine("Enter the subject name: ");
        string subjectName = Console.ReadLine();

        Console.WriteLine("Enter the subject code: ");
        string subjectCode = Console.ReadLine();

        Subject subject = new Subject(subjectName, subjectCode);

        Console.WriteLine("Enter the number of questions for the exam:");
        int numberOfQuestions ;
        if (!int.TryParse(Console.ReadLine(), out numberOfQuestions))
         {
             throw new FormatException("Invalid input! The number of questions must be an integer.");
         }

        Exam exam = new Exam(numberOfQuestions, subject);

        for(int i=0;i<numberOfQuestions;i++)
         {
           Console.WriteLine($"The Question {i+1}");
           Console.WriteLine("what want type of the Question you want ");
           Console.WriteLine("       1-True Or False ");
           Console.WriteLine("       2-Choose one ");
           Console.WriteLine("       3-Choose mult ");
            int Type ;
            if (!int.TryParse(Console.ReadLine(), out Type))
           {
               throw new FormatException("Invalid input! Marks must be an integer.");
           }
         Console.WriteLine("Enter the question header: ");
         string header = Console.ReadLine();

        Console.WriteLine("Enter the question Mark: ");
        int Mark ; 
        if (!int.TryParse(Console.ReadLine(), out Mark))
        {
          throw new FormatException("Invalid input! Marks must be an integer.");
        }

        Console.WriteLine("Enter the question body: ");
        string body = Console.ReadLine();

        string[] options = null;
        string[] answers = null;

    if (Type == 1)
  {
    Console.WriteLine("Enter the answer (True/False): ");
    string answer = Console.ReadLine().ToLower();
    if (answer != "true" && answer != "false")
    {
       throw new ArgumentException("Invalid input for answer. Must be 'true' or 'false'.");
    }
    TrueOrFalseQuestion q1 = new(header, Mark,body,numberOfQuestions,Type,answer);
    exam.AddQuestion(q1);

  }

   else if (Type == 2)
  {
    Console.WriteLine("How many options?");
    int optionCount = int.Parse(Console.ReadLine());
    options = new string[optionCount];

    for (int z = 0; z < optionCount; z++)
    {
        Console.WriteLine($"Enter option {z + 1}: ");
        options[z] = Console.ReadLine();
    }

    Console.WriteLine("Enter the correct answer:");
    string answer = Console.ReadLine().ToLower();
    ChooseOneQuestion q1 = new(header, Mark, body, numberOfQuestions ,Type, options, answer);
   exam.AddQuestion(q1);
}

else if (Type == 3)
 {
      Console.WriteLine("How many options?");
                int optionCount = int.Parse(Console.ReadLine());
                options = new string[optionCount];

                for (int j = 0; j < optionCount; j++)
                {
                    Console.WriteLine($"Enter option {j + 1}: ");
                    options[j] = Console.ReadLine();
                }

                Console.WriteLine("How many correct answers?");
                int answerCount = int.Parse(Console.ReadLine());
                answers = new string[answerCount];

                for (int j = 0; j < answerCount; j++)
                {
                    Console.WriteLine($"Enter correct answer {j + 1}: ");
                    answers[j] = Console.ReadLine();
                }
    ChooseMultiQuestion q1 = new(header, Mark, body, numberOfQuestions ,Type, options, answers);
    exam.AddQuestion(q1);
} 
   
}
       foreach (var question in exam.Questions)
        {
            question.DisplayQuestion(subject);
            Console.WriteLine("Enter your answer: ");
            string userAnswer = Console.ReadLine();

            if (question.CheckAnswer(userAnswer))
            {
                Console.WriteLine("Correct answer");
                totalMark+=question.Marks;
                // Console.WriteLine(exam.CalcMark());
            }
            else
            {
                Console.WriteLine("Incorrect answer.");
            }
           
        }

        exam.ShowCorrectAnswers();
        Console.WriteLine($"Your total score is: {totalMark} marks.");

        }
            catch (FormatException ex)
            {
                Console.WriteLine($"Input error: {ex.Message}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Argument error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
            finally { Console.WriteLine(Console.ReadLine()); }




