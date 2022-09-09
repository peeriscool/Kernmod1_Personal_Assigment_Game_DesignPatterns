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
	
	EnemyAttackState attack; //for envoirment timed states (counting in seconds)
	EnemyidleState idle ; //a state that sine moves a cube (for now)
	StateMachine<FSMOwner> SampleMachine;
    void Start()
	{
		SampleMachine = new StateMachine<FSMOwner>();   //create statemachine
	    
		attack = new EnemyAttackState(); //add states
		idle = new EnemyidleState();
		SampleMachine.AddState(attack); //assign states to 
	    SampleMachine.AddState(idle);
		//  SampleMachine.OnStart(attack);              //parse states to machine
        
    }
	//50 ticks a sec
    void FixedUpdate()
    {
	    if (Input.GetKeyDown(KeyCode.A) == true)
        {
		    // SampleMachine.OnStart(attack);           
        }
	    if (Input.GetKeyDown(KeyCode.S) == true)
	    { 
	    	//SampleMachine.OnStart(idle);  
	    }
	    // SampleMachine.OnUpdate(); //update state machine 
    }
}
