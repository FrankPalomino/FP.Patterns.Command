using FP.Patterns.Command.Exercice0;

Device light = new LightDevice("Lights");
Device tv = new TVDevice("TV");
Device musicSystem = new MusicSystemDevice("Music System");

ICommand turnOnLight = new TurnOn(light);
ICommand turnOnTV = new TurnOn(tv);
ICommand turnOnMusicSystem = new TurnOn(musicSystem);

RemoteControl remoteControl = new RemoteControl();

remoteControl.SetCommand(turnOnLight);

remoteControl.PressButton();

remoteControl.SetCommand(turnOnTV);

remoteControl.PressButton();