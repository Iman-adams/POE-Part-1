# REND - Cybersecurity Awareness Chatbot

An interactive C# console application designed to educate users on digital threats and online safety through a personalized, mulimedia-driven experience.

## YouTub video

## Features
- *Dynamic Interaction:* Simulated typing effect for a natural conversation feel.
- *Personalization:* User-aware responses that adapt based on the provided name.
- *Comprehensive knowledge base:* Over 30+ cybersecurity topics including:\
   - Social Engineering (Phishing, Vishing, Smishing)
   - Finanical scams (FICA, Crypto, Investment)
   - Technical threats (Ransomware, Rootkits, RATs)

## Technical Archiecture
The project follows clean coding principles by separating concerns into modular classes:
- *Program.cs*: Handles the UI loop, color formatting, and user navigation.
- *RendBot.cs*: Manages the response logic using a Case-Insensitive Dictionary.
- *VoiceGreeting*: Utility for handling audio paths and playback via System.Media.
