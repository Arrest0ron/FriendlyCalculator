using Godot;
using System;

public partial class LineEdit : Godot.LineEdit
{
	// Called when the node enters the scene tree for the first time.

	
	public override void _Ready()
	{
	}
	private void OnCalculateButtonPressed()
	{
		Label label = GetNode<Label>("../AnswerLabel");
		if (label == null)
		{
			GD.PushWarning("zero fetch in ",Name);
		}
		if (label.Text != "Введите любое выражение")
			label.Text = "Введите любое выражение";
	}
	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
