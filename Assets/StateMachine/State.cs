using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State
{
	/// <summary>
	/// the States keep track of the enter and exit points of a loop
	/// with the Status delegate 
	/// </summary>
    //public State(StateMachine owner) 
    //{
    //    this.owner = owner;
    //}
    protected StateMachine owner;
    public abstract void OnEnter();
    public abstract void OnUpdate();
    public abstract void OnExit();

	public delegate bool Isfinished(); //Delegates are used to pass methods as arguments to other methods
	public Isfinished Status;
}
