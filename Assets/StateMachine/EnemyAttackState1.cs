using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttackState : State<int>
{
	GameObject Obj;
	public int SyncTime = 0; //Fixed update count till 30 for 1 sec
	Vector3 NewLocation;
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
		if(SyncTime >= 120) //4sec
		{
			NewLocation = new Vector3(Random.Range(-15, 15), 0, Random.Range(-15, 15));
			SyncTime = 0;
		}
		//Debug.Log(this.Name);
		Obj.transform.localPosition = Vector3.MoveTowards(Obj.transform.localPosition,NewLocation,0.1f);
		
		SyncTime++;
		
	}
	public override void OnExit()
	{
		Debug.Log("exit attack");
	}
}
