using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SormHarj2
{
    class Program
    {
        static void DrawLotto()     //Arvotaan 7 numeroa väliltä 1-40
        {
            int NumberOfLines;
            
            Console.WriteLine("Montako riviä pelataan (Väh. 3)? ");
            NumberOfLines = int.Parse(Console.ReadLine());

            if (NumberOfLines < 3)
            {
                NumberOfLines = 0;
                Console.WriteLine("Rivien vähimmäismäärä on 3.");
                Console.WriteLine("Montako riviä pelataan (Väh. 3)?");
                NumberOfLines = int.Parse(Console.ReadLine());
            }

            int[] Numbers = new int[NumberOfLines];

        }
        static void Main(string[] args)
        {
            DrawLotto();
        }
    }
}
