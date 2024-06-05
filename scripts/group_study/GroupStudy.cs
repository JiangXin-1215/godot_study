using Godot;
using System;

public partial class GroupStudy : Node
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (Input.IsActionJustReleased("左"))
		{
			//获取NPC分组
			var npcGroup = GetTree().GetNodesInGroup("NPC");
			//遍历分组
			// foreach (Node node in npcGroup)
			// {
			// 	//将节点转换为Sprite2D
			// 	Sprite2D npc = (Sprite2D)node;
			// 	//调用精灵的翻转方法
			// 	npc.FlipV = !npc.FlipV;
			// }
			GetTree().CallGroup("NPC", "MyFlip");
		}
		else if (Input.IsActionJustReleased("右"))
		{
			//获取玩家精灵
			Sprite2D player = GetNode<Sprite2D>("Player");
			//调用玩家精灵的翻转方法
			player.FlipV = !player.FlipV;
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
