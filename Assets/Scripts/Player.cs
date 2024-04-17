using Godot;
using System;

public partial class Player : CharacterBody2D
{
	float move_speed = 100.0F;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _PhysicsProcess(double delta)
	{
		GetInput();
		MoveAndCollide(Velocity * (float)delta);
	}
	
	public void GetInput () {
		Vector2 inputDir = Input.GetVector ("ui_left", "ui_right", "ui_up", "ui_down");
		Velocity = inputDir * move_speed;
	}
}
