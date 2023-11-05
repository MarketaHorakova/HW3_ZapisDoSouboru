//Vytvoř program
// načítej řádky, dokud není načtený prázdný řádek a zapisuj je do souboru.
//Následně obsah souboru vypiš.

//Možná vylepšení:
//udělej na úvod menu jestli chce uživatel přidávat řádky nebo vypsat soubor.
//pořeš aby prvním řádkem se soubor přepsal a další se jen přidávaly
//dej na výběr jestli se zápisem má soubor přepsat nebo se má přidat na konec
//umožni zadání cesty uživatelem

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HW3_ZapisDoSouboru
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Set variable: path, Number Menu
            string yesNoInput;
            string pathToTxt = @"C:\Users\marketa.zemlova\Visual Studio 2023\C sharp 2\HW3_ZapisDoSouboru\Zapis_Z_Konzole.txt";
            int choosenNumber;
            string oneLine = "nothing";

            //Choose own path
            do 
            {
                Console.WriteLine("Do you want choose a path? (y/n)");
                yesNoInput = Console.ReadLine();
                if (yesNoInput == "y" || yesNoInput == "Y")
                {
                    Console.WriteLine("Please write a path to file with .txt:");
                    pathToTxt = Console.ReadLine();
                }
                else if (yesNoInput == "N" || yesNoInput == "n")
                {
                    Console.WriteLine("Standart path will be used.");
                }
                else
                {
                    Console.WriteLine("Invalid input, please do it again:");
                }

            }
            while ((yesNoInput == "n") || (yesNoInput == "N") || (yesNoInput == "y") || (yesNoInput == "Y"));


            //Menu + Check choises
            Console.WriteLine("Hi, what do you want to do now?");
            Console.WriteLine("0 - End");
            Console.WriteLine("1 - Rewrite text file");
            Console.WriteLine("2 - Add to the end of the text file");
            Console.WriteLine("3 - Show the content from file");
           

            while (!int.TryParse(Console.ReadLine(), out choosenNumber) || choosenNumber > 4 || choosenNumber < 0)
            {
                Console.WriteLine("Wrong input, try it again:");
            }
                        
            //Continue program in switch
            switch (choosenNumber)
            {
                case 0: 
                    break; 
                //Rewrite File
                case 1:
                    Console.WriteLine("You can start write:");
                    File.Delete(pathToTxt);
                    while (oneLine != "\n")
                    { 
                        oneLine = Console.ReadLine() + "\n"; 
                        File.AppendAllText(pathToTxt, oneLine);
                    }
                    break;  
                //Add to File
                case 2:
                    Console.WriteLine("You can start write:");
                    while (oneLine != "\n")
                    {
                        oneLine = Console.ReadLine() + "\n";
                        File.AppendAllText(pathToTxt, oneLine);
                    } 
                    break;
                //Output the text from file
                case 3:                                                     
                    string textFromFile = File.ReadAllText(pathToTxt);
                    Console.WriteLine(textFromFile);
                    break; 
            }




           // Console.ReadLine();



        }
    }
}
