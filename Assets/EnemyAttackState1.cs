using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttackState : State<EnemyAttackState>
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
