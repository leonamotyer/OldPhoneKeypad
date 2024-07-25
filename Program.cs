using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronCodingChallenge
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("New message\n write ## to exit");
            string input = Console.ReadLine();
            while (input != "##")
            {
                Console.WriteLine(OldPhonePadTranslator.OldPhonePad(input));
                input = Console.ReadLine();
            }

                Console.ReadLine();
        }
    }

}
