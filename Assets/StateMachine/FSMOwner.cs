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
	
	EnvoirmentIdle State1; //for envoirment timed states (counting in seconds)
	DefaultState State2 ; //a state that sine moves a cube (for now)
	StateMachine SampleMachine;
    void Start()
    {
	    State1 = new EnvoirmentIdle(); //define states 
	  
	    SampleMachine = new StateMachine(State1);   //create statemachine
	    
	    State2 = new DefaultState(SampleMachine);
	    SampleMachine.AddState(State2);
        SampleMachine.OnStart(State1);              //parse states to machine
        
    }
	//50 ticks a sec
    void FixedUpdate()
    {
	    if (Input.GetKeyDown(KeyCode.A) == true)
        {
	        SampleMachine.OnStart(State1);           
        }
	    if (Input.GetKeyDown(KeyCode.S) == true)
	    { 
	    	SampleMachine.OnStart(State2);  
	    }
	    SampleMachine.OnUpdate(); //update state machine 
    }
}
