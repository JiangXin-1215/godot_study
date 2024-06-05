using Godot;
using System;

//对游戏做一些管理设定
public partial class Info : Node
{
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        GD.Print("在项目设置中设定自动加载就能很方便的创建一个游戏生命周期的单例脚本");
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
    {
    }
}