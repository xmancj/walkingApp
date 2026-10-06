using Godot;
using System;

public partial class Walking : Node2D
{	
	int stepsRemaining = 0;
	int stepsWalked    = 0;
	
	[Signal]
	public delegate void StepsRemaingLoadedEventHandler(int stepsRemaining);
	
	[Signal]
	public delegate void StepsWalkedLoadedEventHandler(int stepsWalked);
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		//loadData();
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		
	}
	
	//private void loadData()
	//{
		//if (!FileAccess.FileExists("user://savegame.save"))
		//{
			//return;
		//}
		//
		//using var saveFile = FileAccess.Open("user://savegame.save", FileAccess.ModeFlags.Read);
		//
		//var saveData = saveFile.get_var();
		//
		//GD.Print(saveData);
		//
		//EmitSignal(SignalName.StepsRemaingLoaded, stepsRemaining);
		//EmitSignal(SignalName.StepsWalkedLoaded, stepsWalked);
	//}
}
