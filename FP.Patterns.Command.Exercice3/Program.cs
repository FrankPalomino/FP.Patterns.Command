using FP.Patterns.Command.Exercice3;

RemoteControl remoteControl = new();

ICommand command = new FanOnCommand();

remoteControl.SetCommand(command);
remoteControl.Execute();

Console.WriteLine($"-----------------------");

command = new FanOffCommand();

remoteControl.SetCommand(command);
remoteControl.Execute();

Console.WriteLine($"-----------------------");

command = new LightOnCommand();

remoteControl.SetCommand(command);
remoteControl.Execute();

Console.WriteLine($"-----------------------");

command = new LightOffCommand();

remoteControl.SetCommand(command);
remoteControl.Execute();

Console.WriteLine($"-----------------------");

command = new SetTemperatureCommand();

remoteControl.SetCommand(command);
remoteControl.Execute();