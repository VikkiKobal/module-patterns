using System;

namespace module_patterns
{
    public class DecreaseVolumeCommand : ICommand
    {
        private readonly AudioSystem _audioSystem;

        public DecreaseVolumeCommand(AudioSystem audioSystem)
        {
            _audioSystem = audioSystem;
        }

        public void Execute()
        {
            _audioSystem.DecreaseVolume();
        }
    }

}
