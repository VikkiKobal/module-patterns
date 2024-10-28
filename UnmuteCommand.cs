using System;

namespace module_patterns
{
    public class UnmuteCommand : ICommand
    {
        private readonly AudioSystem _audioSystem;

        public UnmuteCommand(AudioSystem audioSystem)
        {
            _audioSystem = audioSystem;
        }

        public void Execute()
        {
            _audioSystem.Unmute();
        }
    }

}
