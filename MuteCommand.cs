using System;

namespace module_patterns
{
    public class MuteCommand : ICommand
    {
        private readonly AudioSystem _audioSystem;

        public MuteCommand(AudioSystem audioSystem)
        {
            _audioSystem = audioSystem;
        }

        public void Execute()
        {
            _audioSystem.Mute();
        }
    }

}
