using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyidleState : State<int>
{
	GameObject Obj;
	public int SyncTime = 0; //Fixed update count till 30 for 1 sec
	Vector3 NewLocation;
	
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
		Obj.GetComponent<Renderer>().material.color = Color.blue;
	}
	public override void OnUpdate()
	{
		if(SyncTime >= 60) //4sec
		{
			NewLocation = new Vector3(Random.Range(-5, 5), 0, Random.Range(-5, 5));
			SyncTime = 0;
		}
		//Debug.Log(this.Name);
		Obj.transform.position = Vector3.MoveTowards(Obj.transform.localPosition,NewLocation,0.1f);
		
		SyncTime++;
		
	}
	public override void OnExit()
	{
		Debug.Log("exit idle");
	}
}
