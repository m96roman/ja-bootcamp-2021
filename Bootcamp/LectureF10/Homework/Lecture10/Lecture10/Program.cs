using System.Threading.Tasks;

namespace Lecture10
{
    partial class Program
    {
        static async Task Main(string[] args)
        {
            await GitService.PrintCount();
        }
    }
}


