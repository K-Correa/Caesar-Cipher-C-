using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t---------------------Cifrado Cesar-----------------------");

            Console.Write("Ingrese un elemento para cifrar: ");
            string ElementToCipher = Convert.ToString(Console.ReadLine());

            string Cifrar = Cipher(ElementToCipher, 6);
            Console.WriteLine($"Elemento cifrado: {Cifrar}");


            string Decifr = Decipher(Cifrar, 6);
            Console.WriteLine($"Elemento decifrado es: {Decifr} ");

            Console.ReadKey();

        }
        static string Cipher(string OriginalText, int Shift)
        {
            char[]  originalTextArray = OriginalText.ToCharArray();
            int FirstCharIdx = 'a';
            int Offset = ('z' - 'a') + 1;

            for (int i = 0; i<originalTextArray.Length; i++)
            {
                char OldCharIdx = originalTextArray[i];
                int OldIdxInAlphabet = OldCharIdx - FirstCharIdx;
                int NewIdxInAlphabet = (OldIdxInAlphabet + Shift) % Offset;

                char NewCharIdx = (char)(FirstCharIdx + NewIdxInAlphabet);
                originalTextArray[i] = NewCharIdx;
            }
            return new string(originalTextArray);
        }
            
        static string Decipher(string CipheredTex, int Shift)
        {
            return Cipher(CipheredTex, Shift * -1);
        }
    }
}
