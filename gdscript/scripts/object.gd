extends CharacterBody2D

@onready var collision_shape: CollisionShape2D = $CollisionShape2D

func enable_collision():
	collision_shape.set_deferred("disabled", false)
