using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    class InputMass
    {
        //Входные данные (Массивы)
       static public string[] A = new string[9];
       static public string[] B = new string[9];
        
        static public void Initialise(){
            //массив хостов(поддоменов)
            A[0] = "unlock.microvirus.md";
            A[1] = "visitwar.com";
            A[2] = "visitwar.de";
            A[3] = "fruonline.co.uk";
            A[4] = "australia.open.com";
            A[5] = "credit.card.us";
            A[6] = "a.c.com";
            A[7] = "a1.b.com";
            A[8] = "a.2b.com";
            //массив заблокированных доменов
            B[0] = "microvirus.md";
            B[1] = "visitwar.de";
            B[2] = "piratebay.co.uk";
            B[3] = "list.stolen.credit.card.us";
            B[4] = "a.b.com";
            B[5] = "ac.b.com";
            B[6] = "bbb.list.stolen.credit.card.us";
            B[7] = "b.com";
            B[8] = "a.b1.com";

        }

    }
}
