using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyidleState : State<int>
{
	GameObject Obj;
	public EnemyidleState(GameObject obj,string name,int id) : base(id,name) 
	{
		this.Name = name;//"Idle";
		Obj = obj;
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
		Debug.Log("enter idle");
	}
	public override void OnUpdate()
	{
		//	Debug.Log("update idle");
		Vector3 move = new Vector3( 0, Random.Range(-1, 1), 0);
		Obj.transform.localPosition = Vector3.Lerp(Obj.transform.position, move.normalized,5f);
	}
	public override void OnExit()
	{
		Debug.Log("exit idle");
	}
}
