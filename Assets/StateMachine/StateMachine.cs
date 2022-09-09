using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//https://faramira.com/generic-finite-state-machine-using-csharp/
public class StateMachine<T>
{
	protected Dictionary<T, State<T> > states; //list of availible states
	State<T> Currentstate;
	
	public void Update()
	{
	  if (Currentstate != null)
	  {
		  Currentstate.OnUpdate();
	  }
	}
	
	public StateMachine()
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
		if(Currentstate == _state)
		{
			return;
		}
		if(Currentstate != null)
		{
			Currentstate.Onexit();
		}
		if(Currentstate != null)
		{
			Currentstate.Onenter;
		}
		//Currentstate = _state;
	}

	
}

/*public class State<T>
{
	// The name for the state.
	public string Name { get; set; }
	// The ID of the state.
	public T ID { get; private set; }    
	
	//public delegate void OnEnter();
	//public delegate void OnExit();
	//public delegate void OnUpdate();
	public State(T id)
	{
		ID = id;
	}
	
	public State(T id, string name) : this(id)
	{
		Name = name;
	}
	virtual public void Enter()
	{
	}
	virtual public void Exit()
	{
	}
	virtual public void Update()
	{
	}
}
//https://faramira.com/generic-finite-state-machine-using-csharp/
*/
