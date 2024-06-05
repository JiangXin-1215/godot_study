using Godot;
using System;

public partial class Player : Sprite2D
{
	// Called when the node enters the scene tree for the first time.
	[Export]
	float speed;
	public override void _Ready()
	{

	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (Input.IsActionPressed("左"))
		{
			//移动
			this.Position += new Vector2(-1, 0).Normalized() * speed;
		}
		else if (Input.IsActionPressed("右"))
		{
			this.Position += new Vector2(1, 0).Normalized() * speed;
		}
		else if (Input.IsActionPressed("上"))
		{
			this.Position += new Vector2(0, -1).Normalized() * speed;
		}
		else if (Input.IsActionPressed("下"))
		{
			this.Position += new Vector2(0, 1).Normalized() * speed;
		}
		else if (Input.IsActionJustReleased("返回主场景"))
		{
			//获取场景树
			SceneTree st = GetTree();
			//跳转主场景
			st.ChangeSceneToFile("res://ui/main.tscn");
		}
	}


	public void OnAreaEntered(Area2D area)
	{
		GD.Print("发生碰撞了:" + area.GetParent().Name);
		this.FlipV = true;
	}

	public void OnAreaExited(Area2D area)
	{
		GD.Print("离开碰撞了:" + area.GetParent().Name);
		if (area.GetParent().Name == "NPC")
		{
			this.FlipV = false;
		}

	}
}
