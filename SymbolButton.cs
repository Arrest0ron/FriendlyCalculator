using Godot;
using System;

public partial class SymbolButton : Button
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	public void OnSymbolButtonPressed(string buttontext)
	{
		LineEdit input = GetNode<LineEdit>("/root/Main/EquationInput");
		input.Text += buttontext;

	}
}
