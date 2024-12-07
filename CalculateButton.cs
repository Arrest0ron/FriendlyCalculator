using Godot;
using System;

public partial class CalculateButton : Godot.Button
{
	string[] states = new string[] {"Calculate!", "Calculated! Click to clear"};
	string state;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		state = states[0];
	}

	private void OnCalculateButtonPressed()
	{
		GD.Print("Button was clicked!");
		Button button = GetNode<Button>("../CalculateButton");
		if (button == null)
		{
			GD.PrintErr("zero fetch.\n");
		}
		if (button.Text == states[0])
		{
			button.Text =  states[1];
		}
		else
		{
			button.Text =  states[0];
		}
	}
	

}
