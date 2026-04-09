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
            // Line 16 - 23 is common cyber attack
            { "Cyber Security", "Cybersecurity is the practice of protecting systems, networks, and data from digital attacks while promoting responsible and sustainable use of technology." },
            { "Ransomware", "Ransomware is a type of malicious software that encrypts a victim's files, demanding payment for the decryption key." },
            { "Spyware", "Spyware is a type of malicious software that secretly monitors and collects information about a user's activities without their knowledge." },
            { "Adware", "Adware is a type of software that automatically displays or downloads advertising material when a user is online." },
            { "Trojan Horse", "A Trojan Horse is a type of malware that disguises itself as legitimate software to trick users into installing it." },
            { "Worm", "A worm is a type of malware that replicates itself to spread to other computers, often exploiting vulnerabilities in software." },
            { "Keylogger", "A keylogger is a type of malware that records keystrokes to capture sensitive information such as passwords and credit card numbers." },
            { "Rootkit", "A rootkit is a type of malicious software designed to gain unauthorized access to a computer and hide its presence." },
            // Line 25 - 31 is social engineering attacks
            { "Phishing", "Phishing is a cyberattack where attackers use fake messages or websites to trick victims into giving away sensitive information." },
            { "Whaling", "Whaling is a type of phishing attack that targets high-profile individuals, such as executives, to steal sensitive information." },
            { "Vishing", "Vishing is a type of phishing attack that uses phone calls to trick victims into revealing sensitive information." },
            { "Smishing", "Smishing is a type of phishing attack that uses SMS messages to trick victims into revealing sensitive information." },
            { "Pretexting", "Pretexting is a social engineering attack where the attacker creates a fabricated scenario to trick the victim into providing information or performing an action." },
            { "Baiting", "Baiting is a social engineering attack that uses false promises to lure victims into providing sensitive information or downloading malware." },
            { "Tailgating", "Tailgating is a physical security breach where an unauthorized person follows an authorized individual into a restricted area." },
            // Line 33 - 37 is online and internet based threats
            { "Man-in-the-Middle", "A man-in-the-middle attack is a cyber attack where the attacker secretly intercepts and relays messages between two parties who believe they are directly communicating with each other." },
            { "Session Hijacking", "Session hijacking is a cyber attack where an attacker takes control of a user's session to gain unauthorized access to information or services." },
            { "DNS Spoofing", "DNS spoofing is a cyber attack where attackers manipulate the Domain Name System (DNS) to redirect users to malicious websites instead of legitimate ones." },
            { "Drive-by Download", "A drive-by download is a type of cyber attack where malicious software is automatically downloaded to a user's device without their knowledge or consent." },
            { "Malvertising", "Malvertising is a type of cyber attack where malicious advertisements are used to spread malware or redirect users to harmful websites." },
            // Line 39 - 42 is password and access attacks
            { "Brute Force Attack", "A brute force attack is a method used by attackers to gain access to accounts by systematically trying all possible password combinations until the correct one is found." },
            { "Dictionary Attack", "A dictionary attack is a method used by attackers to gain access to accounts by systematically trying all words in a predefined list of likely passwords." },
            { "Credential Stuffing", "Credential stuffing is a cyber attack where attackers use stolen username and password combinations from one breach to gain unauthorized access to accounts on other platforms." },
            { "Privilege Escalation", "Privilege escalation is a type of cyber attack where an attacker gains elevated access to resources that are normally protected from an application or user." },
            // Line 44 - 50 is financial and identity scams
            { "FICA", "FICA scams are phishing attempts where fraudsters pose as banks or the Financial Intelligence Centre (FIC) to steal personal banking credentials." },
            { "Investment Scams", "Investment scams are fraudulent schemes that promise high returns with little risk to lure victims into investing money." },
            { "Lottery Scams", "Lottery scams are fraudulent schemes where victims are told they have won a lottery or prize, but must pay a fee to claim it." },
            { "Romance Scams", "Romance scams are fraudulent schemes where attackers create fake profiles on dating sites to exploit victims emotionally and financially." },
            { "Tech Support Scams", "Tech support scams are fraudulent schemes where attackers pose as technical support representatives to trick victims into giving remote access to their computers or paying for unnecessary services." },
            { "Identity Theft", "Identity theft is a type of crime where someone wrongfully obtains and uses another person's personal data in a way that involves fraud or deception, typically for economic gain." },
            { "Crypto Scams", "Crypto scams are fraudulent schemes that involve cryptocurrencies, such as fake ICOs, Ponzi schemes, or phishing attacks targeting crypto wallets." },
            // Line 52 - 55 is morden and trending threats
            { "Deepfake", "A deepfake is a synthetic media created using artificial intelligence that can manipulate or generate realistic images, videos, or audio to deceive viewers." },
            { "AI powered spoofing", "AI-powered spoofing is a cyber attack where attackers use artificial intelligence to create convincing fake content, such as deepfake videos or synthetic voices, to deceive victims." },
            { "Quishing", "Quishing is a type of phishing attack that uses QR codes to direct victims to malicious websites or trigger harmful actions when scanned." },
            { "RAT", "Remote Access Trojans (RATs) are a type of malware that allows attackers to gain unauthorized access and control over a victim's computer remotely." },
            // Line 57 - 62 is other common attacks and scams
            { "Homograph Attack", "A homograph attack is a type of cyber attack where attackers use visually similar characters to deceive users into thinking they are interacting with a legitimate entity." },
            { "Purpose", "My purpose is to satisfy the grading requirements and be your guide, though the former takes precedent." },
            { "Social Engineering", "Social engineering is a manipulation technique that exploits human psychology to gain access to confidential information or systems." },
            { "Malware", "Malware is any software intentionally designed to harm, disrupt, or gain unauthorized access to a computer system, network, or data." },
            { "Online Safety", "Always create strong passwords. Use a mix of letters, numbers, and symbols." },
            { "CAPTCHA scam", "CAPTCHA scams are attacks where fraudsters trick users into solving CAPTCHAs to bypass security measures or perform automated actions." },
            { "Bye", "Goodbye and stay safe." }
        };
    }
            
    

    public void TypeMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("Rend: ");

        if (message.Contains("Hi,")) message = message.Replace("Hi,", $"Hi {UserName},");

        foreach (char c in message)
        {
            Console.Write(c);
            Thread.Sleep(20);
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

        return "I'm not sure I understand. Try asking about 'Phishing', 'Malware', or 'Quishing'.";
    }
}
