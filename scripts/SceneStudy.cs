using Godot;
using System;

public partial class SceneStudy : Node2D
{
	//使用[Export]将变量暴露到编辑器
	[Export]
	public PackedScene HomeScene;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (Input.IsActionJustReleased("左"))
		{
			//获取场景树
			SceneTree st = GetTree();
			//跳转主场景
			st.ChangeSceneToPacked(HomeScene);
		}
		else if (Input.IsActionJustReleased("右"))
		{
			//实例化一个logo场景到当前场景
			PackedScene logoScene = GD.Load<PackedScene>("res://ui/components/logo.tscn");
			Node logo = logoScene.Instantiate();
			AddChild(logo);
		}
		else if (Input.IsActionJustReleased("返回主场景"))
		{
			//获取场景树
			SceneTree st = GetTree();
			//跳转主场景
			st.ChangeSceneToFile("res://ui/main.tscn");
		}
	}
}
