using Godot;
using System;

public partial class StepsWalked : RichTextLabel
{
	int totalSteps = 0;
	int newSteps   = 0;
	
	[Signal]
	public delegate void StepsWalkedUpdatedEventHandler(int newSteps);
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	
	public void _on_add_steps_button_pressed()
	{
		totalSteps += newSteps;
		changeStepCount(totalSteps);
	}
	
	public void _on_add_steps_input_value_changed(int steps)
	{
		newSteps = (int)steps;
	}
	
	private void changeStepCount(int newSteps)
	{
		Text = newSteps.ToString();
		EmitSignal(SignalName.StepsWalkedUpdated, newSteps);
	}
}
