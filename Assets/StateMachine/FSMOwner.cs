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
	// 
	/// </summary>
	public GameObject enemy;
	EnemyAttackState attack; //for envoirment timed states (counting in seconds)
	EnemyidleState idle; //a state that sine moves a cube (for now)
	StateMachine<GameObject> SampleMachine = new StateMachine<GameObject>();
	void Start()
	{
		SampleMachine = new StateMachine<GameObject>();   //create statemachine

		attack = new EnemyAttackState(enemy, "Attack"); //add states
		idle = new EnemyidleState(enemy, "Idle");
		SampleMachine.AddState(attack); //assign states to machine
		SampleMachine.AddState(idle);
		//  SampleMachine.AddState(idle);
		//	SampleMachine.OnStart(attack); //first starting point
		SampleMachine.SetCurrentState(attack);
	}
	//50 ticks a sec
	void FixedUpdate()
	{
		SampleMachine.Update();
	//	if (Input.GetKeyDown(KeyCode.A) == true)
	//	{
	//			SampleMachine.OnStart(attack);
	//	}
	//	if (Input.GetKeyDown(KeyCode.S) == true)
	//	{
	//		SampleMachine.OnStart(idle);
	//	}
	}
}
