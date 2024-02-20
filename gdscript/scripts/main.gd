extends Node2D

var is_loading: bool = true

var scene
var obj

@export var object: PackedScene

func _ready():
	load_scene()

func _process(_delta):
	if !is_loading && Input.is_action_pressed("Reload"):
		is_loading = true
		call_deferred("on_reload")
		
func on_reload():
	scene.free()
	obj.free()
	load_scene()

func load_scene():
	var test_scene = load("res://gdscript/test_scene.tscn")
	scene = test_scene.instantiate()
	add_child(scene)
	
	obj = object.instantiate()
	add_child(obj)
	obj.global_position = Vector2(256, 256)
	obj.enable_collision()
	
	is_loading = false
