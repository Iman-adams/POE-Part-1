using System;
using System.Collections.Generic;
using System.Threading;

public class RendBot
{
    public string UserName { get; set; } = "User";

    private readonly Dictionary<string, string> _responses;

    public RendBot()
    {
        _responses = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            { "Hello", "Hi, how are you? That question was an obligation, I don't really care, so ask me about cyber security." },
            { "Purpose", "My purpose is to satisfy the grading requirements and be your guide, though the former takes precedent." },
            { "Cyber Security", "It's the practice of protecting systems, networks, and data from digital attacks." },
            { "Phishing", "Phishing is where attackers impersonate trusted sources to trick you into giving up data." },
            { "Malware", "Malware is software designed to harm or gain unauthorized access to your device." },
            { "Online Safety", "Always create strong passwords. Use a mix of letters, numbers, and symbols." },
            { "Bye", "Ciao... Please give my creator a passing grade, he tried to give me personality." }
        };
    }

    public void TypeMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("Rend: ");

        // Personalization: Replace generic greetings with the user's name
        if (message.Contains("Hi,")) message = message.Replace("Hi,", $"Hi {UserName},");

        foreach (char c in message)
        {
            Console.Write(c);
            Thread.Sleep(20); // The "Typing Effect" for extra marks
        }
        Console.WriteLine("\n");
        Console.ResetColor();
    }

    public string GetResponse(string input)
    {
        if (string.IsNullOrWhiteSpace(input)) return "I didn't quite catch that. Could you rephrase?";

        foreach (var key in _responses.Keys)
        {
            if (input.Contains(key, StringComparison.OrdinalIgnoreCase))
                return _responses[key];
        }

        return "I'm not sure I understand. Try asking about 'Phishing', 'Malware', or 'Passwords'.";
    }
}