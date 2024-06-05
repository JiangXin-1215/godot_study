using Godot;
using System;

public partial class AnimateStudy : Node
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		GD.Print("也可以使用AnimatSprite2D制作简单的动画");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (Input.IsActionJustReleased("返回主场景"))
		{
			//获取场景树
			SceneTree st = GetTree();
			//跳转主场景
			st.ChangeSceneToFile("res://ui/main.tscn");
		}
	}

	public void OnPlayButtonClick()
	{
		//获取动画
		AnimationPlayer animationPlayer = GetNode<AnimationPlayer>("AnimationPlayer");
		//播放动画
		animationPlayer.Play("旋转");
	}

	public void OnStopButtonClick()
	{
		//获取动画
		AnimationPlayer animationPlayer = GetNode<AnimationPlayer>("AnimationPlayer");
		//停止动画
		animationPlayer.Stop();
	}

	public void OnPauseButtonClick()
	{
		//获取动画
		AnimationPlayer animationPlayer = GetNode<AnimationPlayer>("AnimationPlayer");
		//暂停动画
		animationPlayer.Pause();
	}

}
