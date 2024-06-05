using Godot;
using System;

public partial class Main : Node2D
{
	//使用[Export]将变量暴露到编辑器
	[Export]
	public PackedScene NextScene;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	public void OnNodeStudyButtonPressed()
	{
		//获取场景树
		SceneTree st = GetTree();
		//跳转场景方法1
		st.ChangeSceneToFile("res://ui/node_study.tscn");
		//跳转场景方法2 跳转到编辑器中设定的场景  这边为了方便使用第一种方法
		// st.ChangeSceneToPacked(NextScene);
	}

	public void OnSceneStudyButtonPressed()
	{
		//获取场景树
		SceneTree st = GetTree();
		//跳转场景方法1
		st.ChangeSceneToFile("res://ui/scene_study.tscn");
	}
}
