// See https://aka.ms/new-console-template for more information
using System;
using CyberSecurityAwarenessTraining;

public class Program
{
    public static void Main(string[] args)
    {
        // Voice Greeting (Multimedia Requirement)
        VoiceGreeting.Greet("FFVII - fanfare.wav");

        // ASCII Header (Visual Requirement)
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

        // 3. User Input Validation & Personalization
        Console.Write("System: Please enter your name: ");
        string nameInput = Console.ReadLine();
        rend.UserName = string.IsNullOrWhiteSpace(nameInput) ? "Valued User" : nameInput;

        rend.TypeMessage($"Hello, I'm Rend. Ask me about cyber security, or say 'Bye' to leave.");
        Console.WriteLine(new string('=', 50));

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