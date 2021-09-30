using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IuriiPlyskaLect3
{
    public class History
    {
        public int Id { get; set; }

        public string Answer { get; set; }

        public string Question { get; set; }

        public string CorrectAnswer { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

      
        public void ChangeConsole()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine(Question);

            Console.ResetColor();
        }
        public virtual string Print()
        {
            return string.Empty;
        }

        public  List<History> Participate(List<History> container, string firstName, string lastName, out int counter)
        {
            counter = 0;
            if (container is null || container.Count == 0)
            {
                Console.WriteLine($"{nameof(container)} can not be null or empty");
                return null;
            }
            
            if (string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(firstName))
            {
                Console.WriteLine($"first and last name can not be null or empty");
                return null;
            }

            FirstName = firstName;
            LastName = lastName;

            foreach (var item in container)
            {
                string reult = item.Print().Trim().ToUpper();
                if (reult == item.CorrectAnswer)
                {
                    counter++;
                }
            }
            return container; 
        }

        public void ShowResult(List<History> container, int counter)
        {
            if (container is null || container.Count == 0)
            {
                Console.WriteLine($"{nameof(container)} can not be null or empty");
                return;
            }

            Console.WriteLine($"You have answered correctly on {counter} questions from {container.Count}");
            Console.WriteLine($"Correct answers are");
            for (int x = 0; x < container.Count; x++)
            {
                Console.WriteLine($"For {x + 1} is {container[x].CorrectAnswer}");
            }
        }
    }

    public class HistoryCaseQuestion : History
    {
        public string A { get; set; }
        public string B { get; set; }
        public string C { get; set; }
        public string D { get; set; }

        public override string Print()
        {
            Console.WriteLine("Please choose correct an answer. Type only A, or B, or C, or D and press Enter button." +
                " If was inputed something else an answer will be not correct. There is no case sensitive for an answer...");

            base.ChangeConsole();

            Console.WriteLine($"A: {A}  B:{B}");

            Console.WriteLine($"C {C}   D:{D}");

            return Console.ReadLine();
        }  
    }

    public class HistoryJustStrQuestion : History
    {
        public override string Print()
        {         
            Console.WriteLine("Please input the right an answer and press Enter button. There is no case sensitive for an answer...");

            base.ChangeConsole();

            return Console.ReadLine();
        } 
    }
}