extends Area2D

@onready var rect: ColorRect = $ColorRect

func _on_body_entered(body):
	rect.color = Color8(255, 0, 0)
	print(body.name + " entered " + name)


func _on_body_exited(body):
	rect.color = Color8(255, 255, 255)
	print(body.name + " exited " + name)
