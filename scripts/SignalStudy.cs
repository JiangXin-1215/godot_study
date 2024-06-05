using Godot;
using System;

public partial class SignalStudy : Node2D
{
	//定义一个信号
	[Signal]
	public delegate void MySignalEventHandler();

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (Input.IsActionJustReleased("左"))
		{
			//发射信号
			//其他模块绑定收到信号即可实现通信
			EmitSignal("MySignal");

		}
		else if (Input.IsActionJustReleased("返回主场景"))
		{
			//获取场景树
			SceneTree st = GetTree();
			//跳转主场景
			st.ChangeSceneToFile("res://ui/main.tscn");
		}
	}

	public void OnSignal()
	{
		GetNode<Label>("LabelHint").Text = "收到信号了!";
	}
}
