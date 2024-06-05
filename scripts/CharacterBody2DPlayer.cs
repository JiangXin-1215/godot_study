using Godot;
using System;

public partial class CharacterBody2DPlayer : CharacterBody2D
{
	NavigationAgent2D nav;

	public override void _Ready()
	{
		nav = GetNode<NavigationAgent2D>("NavigationAgent2D");
	}

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

	public override void _PhysicsProcess(double delta)
	{
		//获取鼠标位置
		var mousePosition = GetGlobalMousePosition();
		//设置导航目标点
		nav.TargetPosition = mousePosition;
		//得到前进方向
		var direction = (nav.GetNextPathPosition() - Position).Normalized();
		//设置速度向该方向移动
		Velocity = direction * 300;
		MoveAndSlide();
	}
}
