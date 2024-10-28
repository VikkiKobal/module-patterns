using System;

namespace module_patterns
{
    public class AudioSystem
    {
        public int Volume { get; private set; }
        public bool IsMuted { get; private set; }

        public AudioSystem()
        {
            Volume = 50;
            IsMuted = false;
        }

        public void IncreaseVolume()
        {
            if (!IsMuted && Volume < 100)
            {
                Volume += 10;
                Console.WriteLine($"Volume increased to: {Volume}");
            }
        }

        public void DecreaseVolume()
        {
            if (!IsMuted && Volume > 0)
            {
                Volume -= 10;
                Console.WriteLine($"Volume decreased to: {Volume}");
            }
        }

        public void Mute()
        {
            IsMuted = true;
            Console.WriteLine("Audio system is muted.");
        }

        public void Unmute()
        {
            IsMuted = false;
            Console.WriteLine("Audio system is unmuted.");
        }
    }
}
