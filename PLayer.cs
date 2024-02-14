using Godot;
using snakegame;
using System;
using System.Collections.Generic;

public partial class PLayer : Sprite2D
{
	private float speed = 500f;
	
	private Sprite2D tail;
	private Vector2 direction;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		Sprite2D sprite = new Sprite2D();
		sprite.Texture = (Texture2D)GD.Load("res://body.svg");
		//sprite.Position = new Vector2(Position.X )
		direction = new Vector2(1,0).Normalized();
		sprite.Position = -direction * this.Texture.GetSize().X;
		AddChild(sprite);
		tail = sprite;

		AddToTail();
	}
	private void AddToTail()
	{
		Sprite2D sprite = new Sprite2D();
		sprite.Texture = (Texture2D)GD.Load("res://body.svg");
		//sprite.Position = new Vector2(Position.X )
		direction = new Vector2(1, 0).Normalized();
		sprite.Position = -direction * this.Texture.GetSize().X;
		tail.AddChild(sprite);
		tail = sprite;
	}
	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		float speed = this.speed * (float)delta;
		if (Input.IsKeyPressed(Key.S))
		{
			Position += new Vector2(0, speed);
		}
		if (Input.IsKeyPressed(Key.W))
		{
			Position += new Vector2(0, -speed);
		}
		if (Input.IsKeyPressed(Key.D))
		{
			Position += new Vector2(speed, 0);

		}
		if (Input.IsKeyPressed(Key.A))
		{
			Position += new Vector2(-speed, 0);
		}
	}
}
