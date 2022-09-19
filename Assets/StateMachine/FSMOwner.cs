using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FSMOwner : MonoBehaviour
{
	/// <summary>
	// EXAMPLE OF HOW TO USE:
	// define states of any type
	// create machine using that type
	// start machine
	/// </summary>
	public GameObject enemy;
	EnemyAttackState attack; //for envoirment timed states (counting in seconds)
	EnemyidleState idle; //a state that sine moves a cube (for now)
	StateMachine<int> SampleMachine = new StateMachine<int>();
	void Start()
	{
		SampleMachine = new StateMachine<int>();   //create statemachine

		attack = new EnemyAttackState(enemy, "Attack",0); //add states
		idle = new EnemyidleState(enemy, "Idle",1);
		SampleMachine.AddState(attack); //assign states to machine
		SampleMachine.AddState(idle);
		//  SampleMachine.AddState(idle);
		//	SampleMachine.OnStart(attack); //first starting point
		SampleMachine.SetCurrentState(attack);
	}

	void Update()
	{
		
        if (Input.GetKeyDown(KeyCode.A) == true)
        {
            SampleMachine.SetCurrentState(idle);
        }
		if (Input.GetKeyDown(KeyCode.S) == true)
		{
			SampleMachine.SetCurrentState(attack);
		}
	}
	void FixedUpdate()
	{
		SampleMachine.Update();
	}
}