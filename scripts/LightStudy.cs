using Godot;
using System;

public partial class LightStudy : Node2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
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
		else if (Input.IsActionJustReleased("鼠标左键"))
		{
			//获取光源对象
			PointLight2D pointLight = GetNode<PointLight2D>("PointLight2D");
			//设置光源位置为鼠标位置
			pointLight.Position = GetGlobalMousePosition();
		}
	}
}
