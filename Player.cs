using Godot;

public partial class Player : CharacterBody3D
{
	[Export]
	public int Health { get; set; } = 40;
	[Export]
	public int Speed { get; set; } = 15;
	[Export]
	public int Gravity = 10;
	private Vector3 _targetVelocity = Vector3.Zero;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}
    public override void _PhysicsProcess(double delta)
    {
        //base._PhysicsProcess(delta);
		var direction = Vector3.Zero;

		if(Input.IsActionPressed("move_right"))
		{
			direction.X += 1.0f;
		}
		if(Input.IsActionPressed("move_left"))
		{
			direction.X -= 1.0f;
		}
		if(Input.IsActionPressed("move_forward"))
		{
			direction.Z += 1.0f;
		}
		if(Input.IsActionPressed("move_backward"))
		{
			direction.Z += 1.0f;
		}
		
		if(direction != Vector3.Zero){
			direction = direction.Normalized();
			GetNode<Node3D>("Pivot").Basis = Basis.LookingAt(direction);
		}
		_targetVelocity.X = direction.X * Speed;
		_targetVelocity.Y = direction.Y * Speed;

		if(!IsOnFloor()){
			_targetVelocity.Y -= Gravity  * (float)delta;
		}
		Velocity = _targetVelocity;
		MoveAndSlide();
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
	{
	}
}
