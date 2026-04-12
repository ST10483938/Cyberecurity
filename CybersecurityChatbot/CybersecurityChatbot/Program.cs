// See https://aka.ms/new-console-template for more information

using CybersecurityChatbot;

class Program
{
    static void Main(string[] args)
    {
        var ui = new ConsoleUI();
        var chatbot = new Chatbot(ui);
        chatbot.Run();

    }
}