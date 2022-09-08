using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//https://faramira.com/generic-finite-state-machine-using-csharp/
public class StateMachineGeneric<T>
{
	protected Dictionary<T, State<T> > states; //list of availible states
	State<T> Currentstate;
	
	public StateMachineGeneric()
	{
		states = new Dictionary<T, State<T>>();
	}

	public void AddState(State<T> _state)
	{
		states.Add(_state.ID, _state);
	}
	
	public State<T> GetState(T stateID)
	{
	if (states.ContainsKey(stateID))
		return states[stateID];
		return null;
	}

	public void SetCurrentState(State<T> _state)
	{
		if(Currentstate != null)
		{
			
		}
		Currentstate = _state;
	}
}

public class State<T>
{
	// The name for the state.
	public string Name { get; set; }
	// The ID of the state.
	public T ID { get; private set; }    
	
	public State(T id)
	{
		ID = id;
	}
	
	public State(T id, string name) : this(id)
	{
		Name = name;
	}
}
//https://faramira.com/generic-finite-state-machine-using-csharp/

