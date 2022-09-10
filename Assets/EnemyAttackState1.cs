using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttackState : State<GameObject>
{
	public EnemyAttackState(GameObject id, string name) : base(id,name) 
	{
		this.Name = name;//"attack";
	}
	
    public override void OnEnter()
	{
		Debug.Log("enter");
		
	}
	public override void OnUpdate()
	{
		Debug.Log(this.Name);
		Vector3 move = new Vector3(Random.Range(-5, 5), 0, Random.Range(-5, 5));
		ID.transform.localPosition = move.normalized ;
	}
	public override void OnExit()
	{
		Debug.Log("exit");
	}
}
