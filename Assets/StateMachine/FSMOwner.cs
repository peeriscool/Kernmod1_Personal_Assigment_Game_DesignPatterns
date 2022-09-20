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
	public List	<GameObject>Enemys;
	EnemyAttackState Attack; //for envoirment timed states (counting in seconds)
	EnemyidleState Idle; //a state that sine moves a cube (for now)
	EnemyJumpState Jump;
	List<StateMachine<int>> AiMachine = new List<StateMachine<int>>();
	//StateMachine<int> SampleMachine = new StateMachine<int>();
	void Start()
	{
		//	SampleMachine = new StateMachine<int>();   //create statemachine
		foreach (GameObject Enemy in Enemys)
		{
			var machine = new StateMachine<int>();

			Attack = new EnemyAttackState(Enemy, "Attack",0); //add states
			Idle = new EnemyidleState(Enemy, "Idle",1);
			Jump = new	EnemyJumpState(Enemy,"Jump",2);
			machine.AddState(Attack); //assign states to machine
			machine.AddState(Idle);
			machine.AddState(Jump);
			machine.SetCurrentState(Attack);
			
			
			AiMachine.Add(machine);
		}
		
	
	}
	//TODO remove monobehavior and add conditions
	// also add foreach statemachine loops to update synchronosly
	void Update()
	{
		
        if (Input.GetKeyDown(KeyCode.A) == true)
        {
	        AiMachine[0].SetCurrentState(Idle);
	        AiMachine[1].SetCurrentState(Idle);
        }
		if (Input.GetKeyDown(KeyCode.S) == true)
		{
			AiMachine[0].SetCurrentState(Attack);
			AiMachine[1].SetCurrentState(Attack);
		}
		if(Input.GetKeyDown(KeyCode.D) == true)
		{
			AiMachine[0].SetCurrentState(Jump);
			AiMachine[1].SetCurrentState(Jump);
		}
	}
	
	void FixedUpdate()
	{
		AiMachine[0].Update();
		AiMachine[1].Update();
	}
}