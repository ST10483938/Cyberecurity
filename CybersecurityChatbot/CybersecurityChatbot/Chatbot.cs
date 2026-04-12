using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace CybersecurityChatbot
{
    internal class Chatbot
    {

        private readonly ConsoleUI _ui;
        private readonly ResponseHandler _responseHandler;
        private string _userName = "User";

        public Chatbot(ConsoleUI ui)
        { _ui = ui;
            _responseHandler = new ResponseHandler();
        }

        public void Run()
        {
            Console.Title = "Cybersecurity Awarenees Bot";
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            PlayVoiceGreeting();
            _ui.DisplayAsciiLogo();
            _ui.PrintDivider();
            GreetUser();
            _ui.PrintDivider();
            StartConversation();
        }
        private void PlayVoiceGreeting()
        {
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "greeting.wav");
                if (File.Exists(path))
                {
                    using var player = new SoundPlayer(path);
                    player.PlaySync();
                }
            }
            catch (Exception ex)
            {
                _ui.PrintError("Could not play voice greeting: {ex.Message}");
            }
        }

        private void GreetUser()
        {
            _ui.PrintBot("Hello! Welcome to the Cybersecurity Awareness Bot.");
            _ui.PrintBot("I'am here to help you stay safe online.");
            _ui.PrintBot("What's your name?");
            _ui.PrintUser();

            string name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name))
            {
                _ui.PrintError("No name entered. I'll call you 'User'. ");
            }
            else
            {
                _userName = name.Trim();
                _ui.PrintBot("Nice to meet you, {_userName}! Let's talk cybersecurity.");
            }
        }

        private void StartConversation() 
        {
            _ui.PrintBot("What would you like to know, {_userName}? (Type 'exit' to quit)");

            while (true) 
            {
                _ui.PrintDivider();
                _ui.PrintUser();
                string input = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(input))
                {
                    _ui.PrintError("I didn't catch that. Please type a question.");
                    continue;
                }

                if (input.Trim().ToLower() == "exit")
                {
                    _ui.PrintBot("Stay safe online, {_userName}! Goodbye!");
                    break;
                }
                string response = _responseHandler.GetResponse(input);
                _ui.PrintBot(response);

                }
            }
        }
    }

