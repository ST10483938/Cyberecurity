using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CybersecurityChatbot
{
    internal class ConsoleUI
    {
        public void PrintDivider()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(new string('=', 60));
            Console.ResetColor();
        }

        public void PrintHeader(string text)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        public void PrintBot(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" [BOT] ");
            Console.ResetColor();
            PrintBot(message);
        }

        public void PrintError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public void PrintUser()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" [YOU] ");
            Console.ResetColor();
        }

        //Typing effort for a convesational feel private void TypeWrite(string message){

        public void DisplayAsciiLogo()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
  ██████╗██╗   ██╗██████╗ ███████╗██████╗ 
 ██╔════╝╚██╗ ██╔╝██╔══██╗██╔════╝██╔══██╗
 ██║      ╚████╔╝ ██████╔╝█████╗  ██████╔╝
 ██║       ╚██╔╝  ██╔══██╗██╔══╝  ██╔══██╗
 ╚██████╗   ██║   ██████╔╝███████╗██║  ██║
  ╚═════╝   ╚═╝   ╚═════╝ ╚══════╝╚═╝  ╚═╝
     Cybersecurity Awareness Bot ");
            Console.ResetColor();
        }


    }
}
