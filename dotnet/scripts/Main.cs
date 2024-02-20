using Godot;

namespace CollisionBug;

public partial class Main : Node2D
{
	private bool isLoading = true;

	private TestScene scene;
	private Object obj;

	[Export]
	public PackedScene Object;

	public override void _Ready()
	{
		Load();
	}

	public override void _Process(double delta)
	{
		if (!isLoading && Input.IsActionPressed("Reload"))
		{
			isLoading = true;
			CallDeferred(MethodName.OnReload);
		}
	}

	private void OnReload()
	{
		scene.Free();
		obj.Free();
		Load();
	}

	private void Load()
	{
		var testScene = GD.Load<PackedScene>("res://dotnet//test_scene.tscn");
		scene = testScene.Instantiate<TestScene>();
		AddChild(scene);

		obj = Object.Instantiate<Object>();
		AddChild(obj);
		obj.GlobalPosition = new Vector2(256, 256);
		obj.EnableCollision();

		isLoading = false;
	}
}
