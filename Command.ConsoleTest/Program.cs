using Command.Pattern;
using Command.Pattern.Commands;
using System;

namespace Command.ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoteControl remote = new RemoteControl();

            Light livingroomLight = new Light();
            LightOnCommand livingroomLightOnCommand = new LightOnCommand(livingroomLight);
            LightOffCommand livingroomLightOffCommand = new LightOffCommand(livingroomLight);

            Light bedroomLight = new Light();
            LightOnCommand bedroomLightOnCommand = new LightOnCommand(bedroomLight);
            LightOffCommand bedroomLightOffCommand = new LightOffCommand(bedroomLight);

            remote.SetCommand(0, livingroomLightOnCommand, livingroomLightOffCommand);
            remote.SetCommand(1, bedroomLightOnCommand, bedroomLightOffCommand);

            Console.WriteLine($"Livingroom light: {livingroomLight.State}");
            Console.WriteLine($"Bedroom light: {livingroomLight.State}");

            remote.OnButtonPressed(0);
            Console.WriteLine($"Livingroom light: {livingroomLight.State}");
            remote.OffButtonPressed(0);
            Console.WriteLine($"Livingroom light: {livingroomLight.State}");

            remote.OnButtonPressed(1);
            Console.WriteLine($"Bedroom light: {bedroomLight.State}");
            remote.OffButtonPressed(1);
            Console.WriteLine($"Bedroom light: {bedroomLight.State}");

            
            Console.ReadKey();
        }
    }
}
