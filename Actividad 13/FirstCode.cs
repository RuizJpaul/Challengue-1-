using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Change_Position
{
    internal class FirstCode
    {
        static void Main(string[] args)
        {
            //Ejercicio 3 
            FourGrades();
            Console.Write("Enter #5 grade: ");
            cambio[0] = int.Parse(Console.ReadLine());
            Console.Write("Enter #5 grade position: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Magenta;
            for (int i = 0; i < NewPosition().Length; i++)
            {
                Console.WriteLine("Position [{0}] -- grade {1}", i, ans[i]);
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static int[] grades = new int[5];
        public static int[] cambio = new int[1];
        public static int n;
        public static void FourGrades()
        {
            int j = 1;
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Nota {0}: ", j++);
                grades[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("");
            for (int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine("Posicion [{0}] -- nota {1}", i, grades[i]);
            }
        }
        public static int[] vector = new int[5];
        public static int[] ans = new int[5];
        public static int[] NewPosition()
        { 
            switch (n)
            {
                case 4:
                    grades[4] = cambio[0];
                    ans = grades;
                    break;
                case 0:
                    for (int i = 1; i < grades.Length; i++)
                    { vector[i]=grades[i-1]; }
                    vector[0] = cambio[0];
                    ans = vector;
                    break;
                case 1:
                    for (int i = 2; i < grades.Length; i++)
                    { vector[i] = grades[i - 1]; }
                    for (int i = 0; i < 2; i++)
                    { vector[i] = grades[i]; }
                    vector[1] = cambio[0];
                    ans = vector;
                    break;
                case 2:
                    for (int i = 3; i < grades.Length; i++)
                    { vector[i] = grades[i - 1]; }
                    for (int i = 0; i < 3; i++)
                    { vector[i] = grades[i]; }
                    vector[2]=cambio[0];
                    ans=vector;
                    break;
                case 3:
                    for (int i = 4; i < grades.Length; i++)
                    { vector[i] = grades[i-1]; }
                    for (int i = 0; i < 4; i++)
                    { vector[i] = grades[i]; }
                    vector[3]=cambio[0];
                    ans = vector;
                    break;
                default:
                    break;
            }
            return ans;
        }

        
        
    }
}
