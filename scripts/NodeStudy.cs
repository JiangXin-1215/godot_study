using Godot;
using System;
//脚本挂载在某个节点上this就是这个节点
public partial class NodeStudy : Node2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		//以精灵为例
		Node2D sprite = GetNode<Node2D>("Sprite2D");
		//CanvasItem常用属性
		//是否可见
		sprite.Visible = true;
		//渲染顺序
		//数值越大越靠前
		sprite.ZIndex = 300;
		//取消相对渲染便于理解
		sprite.ZAsRelative = false;
		//Node2D常用属性
		//位置
		// sprite.Position = new Vector2(100, 100);
		//旋转
		//弧度?
		// sprite.Rotation = 0.1f;
		//角度
		// sprite.RotationDegrees = 45;
		//缩放
		sprite.Scale = new Vector2(2, 2);
		//倾斜 0为正常 负数为左倾 正数为右倾
		sprite.Skew = 0;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		// Input.IsActionJustPressed("左"); 虚拟按键左被按下
		// Input.IsActionJustReleased("左"); 虚拟按键左放开
		// Input.IsActionPressed("左");虚拟按键一直被按着
		//得到父节点
		// Node2D parent = GetParent<Node2D>();
		if (Input.IsActionJustReleased("左"))
		{
			GD.Print("左键放开了");
			//获取当前场景根节点
			Node root = GetTree().CurrentScene;
			//找到精灵节点
			Node2D sprite = root.GetNode<Node2D>("Sprite2D");
			//解除挂载
			this.RemoveChild(sprite);
			//换个位置
			sprite.Position = new Vector2(0, 0);
			//重新挂载
			root.GetNode<Label>("Caption").AddChild(sprite);
			//删除节点
			// sprite.QueueFree();
		}
		else if (Input.IsActionJustReleased("右"))
		{
			GD.Print("右键放开了");
			//获取当前场景根节点
			Node root = GetTree().CurrentScene;
			//新增一个Label
			Label label = new Label();
			label.Text = "新的Label";
			//添加到根节点
			root.AddChild(label);
		}
		else if (Input.IsActionJustReleased("返回主场景"))
		{
			//获取场景树
			SceneTree st = GetTree();
			//跳转主场景
			st.ChangeSceneToFile("res://ui/main.tscn");
		}

		//获取鼠标位置
		var pos = GetGlobalMousePosition();
		//看向某个点
		Node2D myLogo = GetNode<Node2D>("Sprite2D");
		myLogo.LookAt(pos);
	}
}
