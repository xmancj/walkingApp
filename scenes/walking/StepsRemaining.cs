using Godot;
using System;

public partial class StepsRemaining : RichTextLabel
{
	int stepsRemaining = 10000;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	
	private void _on_steps_walked_steps_walked_updated(int stepsWalked) 
	{
		stepsRemaining -= stepsWalked;
		Text = stepsRemaining.ToString();
		
		//saveData(stepsRemaining, stepsWalked);
	}
	
	//private void saveData(int stepsRemaining, int stepsWalked)
	//{
		//var save = new Godot.Collections.Dictionary<string, int>()
		//{
			//{"stepsRemaining", stepsRemain`ing},
			//{"stepsWalked", stepsWalked}
		//};
		//
		//using var saveFile = FileAccess.Open("user://savegame.save", FileAccess.ModeFlags.Write);
		//
		//saveFile.store_var(save);
	//}
}
