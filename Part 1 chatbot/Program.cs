// See https://aka.ms/new-console-template for more information
using System;
using CyberSecurityAwarenessTraining;

public class Program
{
    public static void Main(string[] args)
    {
        // Voice Greeting
        VoiceGreeting.Greet("FFVII - fanfare.wav");

        // ASCII Header
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(@"  ____  _____ _   _ ____  ");
        Console.WriteLine(@" |  _ \| ____| \ | |  _ \ ");
        Console.WriteLine(@" | |_) |  _| |  \| | | | |");
        Console.WriteLine(@" |  _ <| |___| |\  | |_| |");
        Console.WriteLine(@" |_| \_\_____|_| \_|____/ ");
        Console.WriteLine("\n      REND - Cyber Security Guide\n");
        Console.ResetColor();

        RendBot rend = new RendBot();

        // User Input Validation & Personalization
        Console.Write("System: Please enter your name: ");
        string nameInput = Console.ReadLine();
        rend.UserName = string.IsNullOrWhiteSpace(nameInput) ? "Valued User" : nameInput;

        // After getting user's name
        rend.TypeMessage($"Hello {rend.UserName}! Welcome to Rend Cyber Security Guide.");

        while (true)
        {
            Console.WriteLine("\nPlease choose your option:");
            Console.WriteLine("1. Learn about Cybersecurity and Scams");
            Console.WriteLine("2. Exit");
            Console.Write("Enter option (1 or 2): ");

            string option = Console.ReadLine();

            if (option == "2")
            {
                rend.TypeMessage("Goodbye and stay safe!");
                break;
            }
            else if (option == "1")
            {
                rend.TypeMessage("Great! You can now ask me about cybersecurity topics like phishing, malware, or FICA.");

                // Inner chat loop
                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write($"{rend.UserName}: ");
                    string input = Console.ReadLine()?.Trim();

                    if (string.IsNullOrEmpty(input)) continue;

                    // Ask if user wants to continue AFTER each response
                    string reply = rend.GetResponse(input);
                    rend.TypeMessage(reply);

                    Console.WriteLine("\nWould you like to:");
                    Console.WriteLine("1. Ask another question");
                    Console.WriteLine("2. Return to main menu");
                    Console.Write("Enter option: ");

                    string subOption = Console.ReadLine();

                    if (subOption == "2")
                        break; // go back to main menu
                }
            }
            else
            {
                Console.WriteLine("Invalid option. Please enter 1 or 2.");
            }
        }

        // Main Interaction Loop
        while (true)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"{rend.UserName}: ");
            string input = Console.ReadLine()?.Trim();

            if (string.IsNullOrEmpty(input)) continue;

            if (input.Equals("bye", StringComparison.OrdinalIgnoreCase))
            {
                rend.TypeMessage(rend.GetResponse("Bye"));
                break;
            }

            string reply = rend.GetResponse(input);
            rend.TypeMessage(reply);
        }
    }
}
