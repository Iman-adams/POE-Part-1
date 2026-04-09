using System;
using System.IO;
using System.Media;

namespace CyberSecurityAwarenessTraining
{
    public static class VoiceGreeting
    {
        public static void Greet(string fileName)
        {
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Audio", fileName);

                if (File.Exists(path))
                {
                    var player = new SoundPlayer(path);
                    player.Play();
                }
            }
            catch
            {
                
            }
        }
    }
}
