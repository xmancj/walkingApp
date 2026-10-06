using Godot;
using System;

public partial class CampaignSelection : Node2D
{
	int campaign_selected = -1;
	var campaigns = {};
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		campaignList.add_item("Bag End to Rivendell");
		campaignList.add_item("458 Miles");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	
	public void _on_campaign_list_button_pressed() 
	{
		// save the selected campaign to the db and change scenes to the 'walking' scene
		
	}
	
	public void _on_campaign_list_item_selected(int index) 
	{
		campaign_select = index;
	}
}
