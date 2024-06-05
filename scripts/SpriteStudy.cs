using Godot;
using System;
//脚本挂载在某个节点上this就是这个节点
public partial class SpriteStudy : Node2D
{
	public Sprite2D sprite;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		sprite = GetNode<Sprite2D>("Sprite2D");
		//加载纹理
		sprite.Texture = GD.Load<Texture2D>("res://icon.svg");
		//是否居中  false为左上角
		sprite.Centered = true;
		//偏移
		sprite.Offset = new Vector2(0, 0);
		//翻转
		//水平翻转
		sprite.FlipH = true;
		//垂直翻转
		sprite.FlipV = true;
		//水平切割为2份
		sprite.Hframes = 2;
		//垂直切割为2份
		sprite.Vframes = 2;
		//当前帧  0-3
		sprite.Frame = 0;
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
}
