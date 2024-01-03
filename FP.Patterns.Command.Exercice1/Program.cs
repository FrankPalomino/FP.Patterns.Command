using FP.Patterns.Command.Exercice1;

Fan fan = new Fan();
Light light = new Light();

FanOnCommand fanCommandOn = new FanOnCommand(fan);
FanOffCommand fanCommandOff = new FanOffCommand(fan);

LightOnCommand lightCommandOn = new LightOnCommand(light);
LightOffCommand lightCommandOff = new LightOffCommand(light);

RemoteControl control = new RemoteControl();

control.SetCommand(fanCommandOn);
control.SetCommand(fanCommandOff);
control.SetCommand(lightCommandOn);
control.SetCommand(lightCommandOff);

control.PressButton();
control.PressButton();
control.PressButton();
control.PressButton();
control.PressButton();