using Godot;
using System;

public partial class level0 : Node2D
{
	private Camera2D _camera;
	private Rect2 _portView;
	private float sizeX;
	private float sizeY;
	private int gridSize;
	private Sprite2D _player;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		gridSize = 50;
		_camera = GetNode<Camera2D>("Camera2D");
		_portView = _camera.GetViewportRect();
		sizeX = _portView.Size.X;
		sizeY = _portView.Size.Y;
		_player = GetNode<Sprite2D>("Player");
		float playerSizeX = _player.Texture.GetSize().X;
		float playersizeY  = _player.Texture.GetSize().Y;
		float heightScale = gridSize / playerSizeX;
		float widthScale = gridSize / playersizeY;
		_player.Scale = new Vector2(heightScale, widthScale);
		//GD.Print(height);
		_player.Position = new Vector2(playerSizeX* heightScale *0.5f, playersizeY * widthScale * 0.5f);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	public override void _Draw()
	{
		// Set the drawing color
		Color gridColor = new Color(0.5f, 0.5f, 0.5f); // Gray color
		
		
		// Define grid properties
		 // Size of each grid cell
		int numCellsX = (int)(float) (sizeX/gridSize); // Number of cells in the X direction
		int numCellsY = (int)(float)(sizeY / gridSize); // Number of cells in the Y direction

		// Calculate grid dimensions
		int gridWidth = gridSize * numCellsX;
		int gridHeight = gridSize * numCellsY;
		int startX = (int)sizeX;
		startX = -startX / 2;
		int startY = (int)sizeY;
		startY = -startY / 2;
		// Draw vertical grid lines
		for (int i = startX; i <= numCellsX; i++)
		{
			int x = i * gridSize;
			DrawLine(new Vector2(x, startY), new Vector2(x, gridHeight), gridColor);
			
		}

		// Draw horizontal grid lines
		for (int j = startY; j <= numCellsY; j++)
		{
			int y = j * gridSize;
			DrawLine(new Vector2(startX, y), new Vector2(gridWidth, y), gridColor);
			
		}
	}
}
