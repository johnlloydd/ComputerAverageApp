using System.Threading.Tasks;
namespace ComputerAverageApp { 

    class ComputerAverageProgram {

    static void Main(string[] args) {

        int[] grades = new int[5];
        Console.WriteLine("Enter Five(5) Grades separated by new line");
       
            for (int i = 0; i < 5; i++)
        {
            grades[i] = Convert.ToInt32(Console.ReadLine());
        }
        int sum = 0;
        double avg = 0;

        for (int i = 0;i < 5;i++)
        {
            sum += grades[i];
        }

        avg = sum / 5.0;

        Console.WriteLine("The average is {0} and round of to {1}.", avg, Math.Round(avg, 0));
        Console.ReadKey();


         }
    }
}
