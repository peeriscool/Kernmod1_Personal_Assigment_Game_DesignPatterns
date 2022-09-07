using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FSMOwner : MonoBehaviour
{
	/// <summary>
	// EXAMPLE OF HOW TO USE:
	// define states
	// create machine 
	// start machine
	// 
	/// </summary>
	
	EnvoirmentIdle State1; //for envoirment timed states
	DefaultState state2 ;
	StateMachine SampleMachine;
    void Start()
    {
	    State1 = new EnvoirmentIdle(); //define states 
	  
	    SampleMachine = new StateMachine(State1);   //create statemachine
	    
	    state2 = new DefaultState(SampleMachine);
	    SampleMachine.AddState(state2);
        SampleMachine.OnStart(State1);              //parse states to machine
        
    }
	//50 ticks a sec
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A) == true)
        {
	        SampleMachine.OnUpdate();                 //update state machine (only when pressed)
        }
	    if (Input.GetKey(KeyCode.S) == true)
	    {
	    	SampleMachine.OnStart(state2);  
	    }

    }
}
