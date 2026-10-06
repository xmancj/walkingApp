using Godot;
using System;

public partial class Main : Node
{
	database : SQLite;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		database = SQLite.new();
		database.path = "res://data.db";
		database.open_db();
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
