using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyidleState : State<EnemyidleState>
{
	
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
