using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyidleState : State<GameObject>
{
	public EnemyidleState(GameObject id,string name) : base(id,name) 
	{
		this.Name = name;//"Idle";
	}
	//public State<EnemyidleState> instance;
	//public EnemyidleState()
	//{
	//	this.Name = "Idle";
	//	Debug.Log(this.ID.instance);
	//	instance.OnEnter();
	//}

	public override void OnEnter()
	{
		Debug.Log("enter");
	}
	public override void OnUpdate()
	{
		Debug.Log("update");
	}
	public override void OnExit()
	{
		Debug.Log("exit");
	}
}
