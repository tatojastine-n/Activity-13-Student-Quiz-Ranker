using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Quiz_Ranker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> studentNames = new List<string>();
            List<int> quizScores = new List<int>();

            Console.WriteLine("Enter 10 student names and their quiz scores:");

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Student {i + 1} name: ");
                string name = Console.ReadLine();

                Console.Write("Quiz score: ");
                if (int.TryParse(Console.ReadLine(), out int score) && score >= 0 && score <= 100)
                {
                    studentNames.Add(name);
                    quizScores.Add(score);
                }
                else
                {
                    Console.WriteLine("Invalid score. Please enter a number between 0-100.");
                    i--; 
                }
            }
            for (int i = 0; i < quizScores.Count - 1; i++)
            {
                for (int j = i + 1; j < quizScores.Count; j++)
                {
                    if (quizScores[i] < quizScores[j])
                    {                    
                        int tempScore = quizScores[i];
                        quizScores[i] = quizScores[j];
                        quizScores[j] = tempScore;

                        string tempName = studentNames[i];
                        studentNames[i] = studentNames[j];
                        studentNames[j] = tempName;
                    }
                }
            }
            Console.WriteLine("\nTop 3 Performers:");
            for (int i = 0; i < 3 && i < studentNames.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {studentNames[i]} - {quizScores[i]}");
            }
        }
    }
}
