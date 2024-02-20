This is a demonstration of a collision bug in Godot.

A scene is setup with 4 Area2Ds with a size of 512x512 placed around the origin.
In the main scene this scene is instantiated and a CharacterBody2D with it's CollisionShape2D initially disabled is also instantiated.
The CharacterBody2D is set to position (256, 256) and then it's CollisionShape2D is enabled with a SetDeferred() call.

Expected behaviour: only one Area2D's OnBodyEntered() function is triggered.
Actual behaviour: all 4 Area2D's OnBodyEntered() function is triggered, then the other 3 Area2D's OnBodyExited() function is triggered.

Pressing spacebar calls a reload function which frees the test scene and the test object and instantiates new ones. The wrong behaviour occurs again.

Reproduceable in Godot Engine v4.2.1.stable.mono.official [b09f793f5] and Godot Engine v4.3.dev3.mono.official [36e943b6b]

Feel free to clone the repo and play around with the code.
