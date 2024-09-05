using FP.Patterns.Command.Exercice4;

Light light = new Light();
LightOnCommand lightOnCommand = new LightOnCommand(light);
LightOffCommand lightOffCommand = new LightOffCommand(light);

RemoteControl remoteControl = new(lightOnCommand);
remoteControl.ExecuteCommand();

light.LightState();

remoteControl.SetCommand(lightOffCommand);
remoteControl.ExecuteCommand();

light.LightState();

remoteControl.UnDoCommand();

light.LightState();