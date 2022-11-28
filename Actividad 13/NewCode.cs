using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_13
{
    //same problem and optimized code
    internal class NewCode
    {
        static void Main(string[] args)
        {
            FourGrades();
            //we notice the blank space in position 4, then we can either complete with a 
            //new number or choose a new position for that number 
            Console.Write("\nEnter #5 grade: ");
            change[0] = int.Parse(Console.ReadLine());
            Console.Write("Enter #5 grade position: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            OptimizedCode(n);
            Console.ForegroundColor = ConsoleColor.Magenta;
            for (int i = 0; i < ans.Length; i++)
            {
                Console.WriteLine("Position [{0}] --> grade {1}: {2}", i,i+1, ans[i]);
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
        //it's 5 in the array because we only want 5 grades to evaluate
        public static int[] grades = new int[5];
        public static int[] change = new int[1];
        public static void FourGrades()
        {
            int j = 1;
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Grade #{0}: ", j++);
                grades[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(" ");
            //we specify the position according the grade
            for (int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine("Position [{0}] --> Grade #{1}: {2}", i,i+1, grades[i]);
            }
        }
        public static int[] ans = new int[5];
        public static int[] OptimizedCode(int posit)
        {
            //the position we choose will force the current number in that position to go down
            //one position and the same with the rest
            int[] vector = new int[5];
            for (int i = posit + 1; i < grades.Length; i++)
            {
                vector[i] = grades[i - 1];
            }
            for (int i = 0; i < posit; i++)
            {
                vector[i] = grades[i];
            }
            vector[posit] = change[0];
            ans = vector;
            return ans;
        }
    }
}
