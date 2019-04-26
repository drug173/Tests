using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] A = InputMass.A;
            string[] B = InputMass.B;
            InputMass.Initialise();
           int[]L= Solution.solution(A,B);
           int lengthMass = L.Length;
           for (int i = 0; i < lengthMass; i++){
               Console.WriteLine(L[i]);
                 }

           //Console.WriteLine(L.Length);

            Console.ReadKey();

        }
    }
}
