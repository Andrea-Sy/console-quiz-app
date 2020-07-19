using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anime_Quiz_Game
{
    class Quiz
    {
        private static List<string> questions = new List<string>();
        private static List<string> answerKey = new List<string>();
        private static List<string> userAnswers = new List<string>();

        public Quiz()
        {
            setQuestions();
            setAnswers();
            displayWelcome();
        }

        public static void displayWelcome()
        {
            Console.WriteLine("\n\n\n\n");
            center("#-#-#-#-# FULLMETAL ALCHEMIST BROTHERHOOD QUIZ #-#-#-#-#");
            center(" ----#-#-# 10 Questions / Multiple Choice #-#-#----");
            center("----------#-#-# GOODLUCK! #-#-#----------\n\n\n");
            center("Press ENTER key to start ...");
            Console.ReadLine();

            Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 2);
            center("                                                           ");

            startQuiz();
        }

        public static void center(string message)
        {
            // Center the text in the console display
            int screenWidth = Console.WindowWidth;
            int stringWidth = message.Length;
            int spaces = (screenWidth / 2) + (stringWidth / 2);

            Console.WriteLine(message.PadLeft(spaces));
        }

        public static void setQuestions()
        {
            // Putting all questions in the list
            questions.Add("\t\tQ1: What colour are Scar's eyes?\n\n" +
                            "\t\t\t\t\ta. Green   b. Blue   c. Red   d. Brown");
            questions.Add("\t\t\t\tQ2: Which of these animals wasn't a part of Chimera Hybrid?\n\n" +
                            "\t\t\t\t\ta. Cow   b. Dog   c. Lion   d. Dolphin");
            questions.Add("\t\tQ3: What was Van Hohenheim's slave number?\n\n" +
                            "\t\t\t\t\ta. 21   b. 33   c. 19   d. 23");
            questions.Add("\t\tQ4: What is Kimblee's first name?\n\n" +
                            "\t\t\t\t\ta. Gunther   b. Dolph   c. Solf   d. Sol");
            questions.Add("\t\t\t\tQ5: What is the name of the alchemy used in Xing?\n\n" +
                            "\t\t\t\t\ta. Alkaholiks   b. Alchemic   c. Alkahestry   d. Alchemisty");
            questions.Add("\t\t\t\tQ6: What is the first name of Winry's grandmother?\n\n" +
                            "\t\t\t\t\ta. Trisha   b. Pinako   c. Hanako   d. Theresa");
            questions.Add("\t\t\t\tQ7: Which character killed Winry's parents?\n\n" +
                            "\t\t\t\t\ta. Lt. Armstrong   b. Envy   c. Scar   d. Fuhrer Bradley");
            questions.Add("\t\t\t\tQ8: Who directed Full Metal Alchemist: Brotherhood?\n\n" +
                            "\t\t\t\ta. Yasuhiro Irie   b. Akira Senju   c. Hiroshi Onogi   d. Ryo Oyama");
            questions.Add("\t\t\tQ9: Where does Van Hohenheim come from?\n\n" +
                            "\t\t\t\t\ta. Amestris   b. Xing   c. Drachma   d. Xerxes");
            questions.Add("\t\t\tQ10: Which Homunculus was killed by Colonel Mustang?\n\n" +
                            "\t\t\t\t\ta. Wrath   b. Envy   c. Lust   d. Gluttony");
        }

        public static void setAnswers()
        {
            answerKey.Add("b"); //answer to question #1
            answerKey.Add("d"); //answer to question #2
            answerKey.Add("d"); //answer to question #3
            answerKey.Add("c"); //answer to question #4
            answerKey.Add("c"); //answer to question #5
            answerKey.Add("b"); //answer to question #6
            answerKey.Add("c"); //answer to question #7
            answerKey.Add("a"); //answer to question #8
            answerKey.Add("d"); //answer to question #9
            answerKey.Add("c"); //answer to question #10
        }

        public static void startQuiz()
        {
            int i = 0;

            do
            {
                center(questions[i]);
                Console.Write("\n\t\t\t\tYour answer:\t");
                userAnswers.Add(Console.ReadLine());
                
                // Clear Question
                Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 5);
                center("                                                                                                                    " +
                       "\n                                                                                                                  " +
                       "\n                                                                                                                  " +
                       "\n                                                                                                                  " +
                       "\n                                                                                                                  " );
                Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 5);

                i++;
            } 
            while (i < questions.Count);

            evaluateQuiz();
        }

        public static void evaluateQuiz()
        {
            int score = 0;
            
            // Count the matching elements in the Answer Key and User Answers
            for(int i=0; i < answerKey.Count; i++)
            {
                if(userAnswers[i] == answerKey[i])
                {
                    score++;
                }
            }

            center("Thank you for taking the quiz.");
            center("YOUR SCORE:\n");
            center(score.ToString() + "/" + questions.Count.ToString() + "\n");

            if (score == questions.Count)
                center("CONGRATULATIONS, YOU'VE GOT A PERFECT SCORE!!");
            else
                center("Better luck next time to achieve a perfect score!");

            // Clear the User Answers before exit
            userAnswers.Clear();
            Console.WriteLine(userAnswers.Count);

        }
    }
}
