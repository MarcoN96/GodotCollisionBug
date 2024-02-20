using Godot;

namespace CollisionBug;

public partial class Object : CharacterBody2D
{
	private CollisionShape2D collisionShape;

	public override void _Ready()
	{
		collisionShape = GetNode<CollisionShape2D>("CollisionShape2D");
	}

	public void EnableCollision()
	{
		collisionShape.SetDeferred(CollisionShape2D.PropertyName.Disabled, false);
	}
}
