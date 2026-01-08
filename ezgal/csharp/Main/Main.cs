using Godot;
using System;

public partial class Main : Node2D
{
	[Export]
	private Sprite2D _startTextureNode;
	[Export]
	private CpuParticles2D _cpuParticles2DNode;
	[Export]
	private AudioStreamPlayer _musicNode;
	[Export]
	private AudioStreamPlayer _soundsNode;
	[Export]
	private BoxContainer _boxContainer;

	public override void _Ready()
	{
		Tools.SetTexture(_startTextureNode,"start_texture");
		_cpuParticles2DNode.Texture = Tools.LoadImage("./image/particle.png");
		_musicNode.Stream = Tools.LoadAudio("./sounds/思念,交织于世界彼端.mp3");
		_musicNode.Play();
		_boxContainer.MouseExited += OnBoxContainerMouseExited;
	}
	
	void OnBoxContainerMouseExited()
	{
		_soundsNode.Play();
	}
}
