using Godot;
using System;

public partial class EntityBase : Node3D
{
    public delegate void Walking();
    public delegate void Die();
    public delegate void InitFollowNoise();

    //Events for Entity Base
    
    public virtual event Walking walking;
    public virtual event Die die;
    public virtual event InitFollowNoise FollowNoise;

}
