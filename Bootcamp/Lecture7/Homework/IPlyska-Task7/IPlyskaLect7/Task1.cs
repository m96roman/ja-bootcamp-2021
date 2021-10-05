using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPlyskaLect7
{
    public class Task1
    {
        public int Number { get; private set; }
        public int SqrNo { get; private set; }

        public  IEnumerable<Task1> FindSquareNumber(IEnumerable<int> container)
        {
            if (container is null || container.Count() == 0)
            {
                throw new ArgumentNullException("Argument can not be null or an empty", nameof(container));
            }

           return container.Select(x => new Task1{ Number = x, SqrNo = x * x });
            
        }

    }

    public static class ExtentionIEnumerable
    {
        public static void PrintObjects(this IEnumerable<Task1> task)
      => task.ToList().ForEach(s => Console.WriteLine($"Number : {s.Number}, SqrNo : {s.SqrNo}"));
    }
}
