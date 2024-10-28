using System;
using module_patterns;

public class Program
{
    public static void Main(string[] args)
    {
        AudioSystem audioSystem = new AudioSystem();

        ICommand increaseVolume = new IncreaseVolumeCommand(audioSystem);
        ICommand decreaseVolume = new DecreaseVolumeCommand(audioSystem);
        ICommand mute = new MuteCommand(audioSystem);
        ICommand unmute = new UnmuteCommand(audioSystem);

        RemoteControl remoteControl = new RemoteControl();

        Console.WriteLine("Доступні команди:");
        Console.WriteLine("1 - Збільшити гучність");
        Console.WriteLine("2 - Зменшити гучність");
        Console.WriteLine("3 - Вимкнути звук");
        Console.WriteLine("4 - Увімкнути звук");
        Console.WriteLine("0 - Вихід");

        while (true)
        {
            Console.Write("Введіть команду: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    ExecuteCommand(increaseVolume, remoteControl);
                    break;
                case "2":
                    ExecuteCommand(decreaseVolume, remoteControl);
                    break;
                case "3":
                    ExecuteCommand(mute, remoteControl);
                    break;
                case "4":
                    ExecuteCommand(unmute, remoteControl);
                    break;
                case "0":
                    Console.WriteLine("Вихід з програми.");
                    return;
                default:
                    Console.WriteLine("Невірна команда!");
                    break;
            }
        }
    }

    private static void ExecuteCommand(ICommand command, RemoteControl remoteControl)
    {
        Console.WriteLine("Виконання команди безпосередньо...");
        command.Execute();

        Console.WriteLine("Виконання команди через пульт...");
        remoteControl.SetCommand(command);
        remoteControl.PressButton();
    }
}
