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
                Console.WriteLine($"Гучність збільшено до: {Volume}");
            }
            else if (IsMuted)
            {
                Console.WriteLine("Не можна збільшити гучність, оскільки система вимкнена.");
            }
            else
            {
                Console.WriteLine("Гучність уже на максимальному рівні.");
            }
        }

        public void DecreaseVolume()
        {
            if (!IsMuted && Volume > 0)
            {
                Volume -= 10;
                Console.WriteLine($"Гучність зменшено до: {Volume}");
            }
            else if (IsMuted)
            {
                Console.WriteLine("Не можна зменшити гучність, оскільки система вимкнена.");
            }
            else
            {
                Console.WriteLine("Гучність уже на мінімальному рівні.");
            }
        }

        public void Mute()
        {
            IsMuted = true;
            Console.WriteLine("Аудіосистема вимкнена.");
        }

        public void Unmute()
        {
            IsMuted = false;
            Console.WriteLine("Аудіосистема увімкнена.");
        }
    }
}
