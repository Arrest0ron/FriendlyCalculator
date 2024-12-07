using Godot;
using System;

public partial class Background : ColorRect
{
	// Called when the node enters the scene tree for the first time.	
	private int theme = 0;
	public override void _Ready()
	{
	}
	private void ThemeButtonPressed()
	{
		GD.Print("Changing theme!\n");
		if (theme < 3)
		{
			Color = Color.Darkened((float) 0.5);
			theme += 1;
		}
		else
		{
			Color = Color.FromHtml("53c07fff");
			theme = 0;
		}
		
	}
	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
