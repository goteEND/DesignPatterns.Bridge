namespace DesignPatterns.Bridge.V1;

class Program
{
    static void Main(string[] args)
    {
        Tv tv = new();
        RemoteControl remote = new(tv);

        while (true)
        {
            Console.WriteLine("Enter a command (1: power, 2: volume up, 3: volume down, 4: channel up, 5: channel down, 0: quit):");
            string command = Console.ReadLine();

            switch (command)
            {
                case "1":
                    remote.TogglePower();
                    break;
                case "2":
                    remote.VolumeUp();
                    break;
                case "3":
                    remote.VolumeDown();
                    break;
                case "4":
                    remote.ChannelUp();
                    break;
                case "5":
                    remote.ChannelDown();
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Unknown command.");
                    break;
            }
        }
    }
}
