using Godot;
using System;

//生命周期方法，脚本从生效-》销毁失效过程中，会自动调用的几个重要方法
public partial class Dragonborn : Sprite2D
{
    public override void _EnterTree()
    // 节点加到树
	{
        base._EnterTree();
		GD.Print("Dragonborn _EnterTree");
    }

	public override void _Ready()
	// 初始化
	{
		GD.Print("Dragonborn _Ready");
	}

	public override void _Process(double delta)
	// 每帧计算
	{
		// 游戏逻辑
	}
    public override void _PhysicsProcess(double delta)
	// 每次物理计算
    {
        base._PhysicsProcess(delta);
    }
    public override void _ExitTree()
    {
        base._ExitTree();
		GD.Print("Dragonborn _ExitTree");
    }

}
