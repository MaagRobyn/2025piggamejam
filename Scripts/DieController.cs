using Godot;
using System;
using System.Collections.Generic;

public partial class DieController : Area2D
{
	[Export]
	public DieFace[] Faces { get; set; }
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
