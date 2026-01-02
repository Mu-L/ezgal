using Godot;
using System;

public partial class Option : Button
{
	private Game _gameScene;
	private Options _optionsScene;

	[Export]
	private Button _optionNode;
	public string set_option { get; set; }

	public override void _Ready()
	{
		_optionsScene = GetNode<Options>("../../Options");
		_gameScene = GetNode<Game>("../../../Game");
		_optionNode.Pressed += OnOptionPressed;
	}

	private void OnOptionPressed()
	{
		Global.Flow new_flow = Global.SetBracesFunc2(set_option);
		_gameScene.Datas[Global.intptr + 1] = new_flow;
		Global.intptr++;
		_optionsScene.Hide();
		_gameScene.Run();
	}
}
