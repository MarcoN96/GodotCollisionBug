using Godot;

namespace CollisionBug;

public partial class Trigger : Area2D
{
	private ColorRect rect;

	public override void _Ready()
	{
		rect = GetNode<ColorRect>("ColorRect");
	}

	private void OnBodyEntered(Node2D body)
	{
		if (body is Object)
		{
			rect.Color = Color.Color8(255, 0, 0);

			GD.Print($"{body.Name} entered {Name}");
		}
	}

	private void OnBodyExited(Node2D body)
	{
		if (body is Object)
		{
			rect.Color = Color.Color8(255, 255, 255);

			GD.Print($"{body.Name} exited {Name}");
		}
	}
}
