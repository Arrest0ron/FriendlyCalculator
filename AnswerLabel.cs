using Godot;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Numerics;

public partial class AnswerLabel : Godot.Label
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		
	}
	private void OnCalculateButtonPressed()
	{
		GD.Print("AnswerLabel/OnCalculateButtonPressed");
		LineEdit myself = GetNode<LineEdit>("../EquationInput");
		if (myself == null)
		{
			GD.PushWarning("ZeroFetch");
		}
		else
		{
			GD.Print("label text: ", myself.Text);
		}
		float answer = Tokenize(myself.Text);
		AnswerLabel answerLabel = GetNode<AnswerLabel>("../AnswerLabel");
		answerLabel.Text = answer.ToString();
	}
	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	// private static string[] Tokenize(string input)
	// {
	// 	List<string> a = new List<string>{};

		

	// }
	private static float Tokenize(string input)
	{
		string currentString= "";
		List<string> tokens = new() { };
		for (int i = 0; i!= input.Length; i++)
		{
			

			if (input[i] == ' ' )
			{
				continue;
			}
			else if ("+-".Contains(input[i]))
			{
				if (currentString != "")
				{
					tokens.Add(currentString);
					tokens.Add(input[i].ToString());
					currentString = "";
				}
				else
				{
					GD.PushWarning("+ or - in the end/start");
				}
			}
			else if ("1234567890.".Contains(input[i]))
			{
				currentString+=input[i];
			}
		}
		if (currentString != "")
		{
			tokens.Add(currentString);
		}
		float answer = 0;
		for (int i = 0; i!=tokens.Count;i++)
		{
			if (tokens[i]=="+")
			{
				answer+= tokens[i+1].ToFloat();
				tokens.RemoveAt(i+1);
			}
			else if (tokens[i]=="-")
			{
				answer-= tokens[i+1].ToFloat();
				tokens.RemoveAt(i+1);
			}
			else
			{
				GD.Print("Converting to float: ", tokens[i]);
				answer+= tokens[i].ToFloat();
			}
		}
		return answer;
	}
}

