using Godot;
using System;

public interface NoiseMaker
{
	public bool MakeNoisePlayer();

	public bool MakeNoiseMonster();

	public bool MakeNoiseObject();

	public bool MakeNoiseStep<T>();
}
