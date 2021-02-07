using System;
using System.Collections.Generic;
using System.IO;

namespace Discord_Nitro_Generator_V2
{
    class Program
    {
        static int Number = 0;
        static string DiscordPrefix = "https://discord.gift/";
        static string DiscordNitroCode;
        static void Main(string[] args)
        {

            List<string> Codes = new List<string>();
            Console.Title = "Discord Nitro Generator";
            Console.WriteLine("How many Discord Nitro Codes do you want? [Enter Amount]");
            Console.Write("> ");
            int Anzahl = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Random Rnd = new Random();
            char[] Chars = "QWERTZUIOPASDFGHJKLYXCVBNMqwertzuiopasdfghjklyxcvbnm1234567890".ToCharArray();
            int x = 16;
            for (int i = 0; i < Anzahl; i++)
            {
                DiscordNitroCode = "";
                for (int y = 0; y < x; y++)
                {
                    DiscordNitroCode += Chars[Rnd.Next(0, 62)].ToString();
                }
                Number++;
                Console.Title = "Generating [Already Generated: "+Number+"]";
                string FinalCode = DiscordPrefix + DiscordNitroCode;
                Codes.Add(FinalCode);
                Console.WriteLine(FinalCode);
            }
            Console.Title = "Done Success fully Generated " + Number+  " Nitro Codes";
            Console.WriteLine("\n\nDone the codes are save at the Path C:\\DiscordNitroCodes.txt");
            string[] DiscordNitroCodeSave = Codes.ToArray();
            File.WriteAllLines(@"C:\DiscordNitroCodes.txt", DiscordNitroCodeSave);
            Console.ReadLine();
        }
    }
}
