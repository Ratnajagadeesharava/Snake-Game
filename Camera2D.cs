using Godot;
using System;

public partial class Camera2D : Godot.Camera2D
{
	
	private float startX;
	private float startY;
	private float sizeX;
	private float sizeY;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		//this.Position = new Vector2(0, 0);
		
		Rect2 portView = this.GetViewportRect() ;
		startX = portView.Position.X ;
		startY = portView.Position.Y ;

		sizeX = portView.Size.X ;
		sizeY = portView.Size.Y ;
		//this.Position = new Vector2(sizeX/2,sizeY/2) ;
		GD.Print(sizeX,",    ", sizeY);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{

	}
}
