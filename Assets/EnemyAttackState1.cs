using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttackState : State<int>
{
	GameObject Obj;
	public EnemyAttackState(GameObject obj, string name, int id) : base(id,name) 
	{
		this.Name = name;//"attack";
		Obj = obj;
	}
	
    public override void OnEnter()
	{
		Debug.Log("enter attack");
		
	}
	public override void OnUpdate()
	{
		//Debug.Log(this.Name);
		Vector3 move = new Vector3(Random.Range(-5, 5), 0, Random.Range(-5, 5));
		Obj.transform.localPosition = move.normalized ;
		
	}
	public override void OnExit()
	{
		Debug.Log("exit attack");
	}
}
