using Godot;
using System;

public partial class Technical : Control
{
	[Export]
	private Keys _keysScene;
	[Export]
	public RichTextLabel TextNode { get; set; }
	
	private Keys _self;

	public override void _Ready()
	{
		Hide();
	}

	// 隐藏对话框
	public new void Hide()
	{
		TextNode.Text = "";
		base.Hide();
	}

	/* 显示对话框
	public new void Show()
	{
		base.Show();
	}
	*/

	public void SetSelf(Keys keysScene)
	{
		this._self = keysScene;
	}

	public void _on_text_meta_clicked(Variant meta)
	{
		Global.LoadTechnical(_self, meta);
	}

	public void _on_button_pressed()
	{
		_keysScene.BackgroundPressed("Technical");
	}
}
