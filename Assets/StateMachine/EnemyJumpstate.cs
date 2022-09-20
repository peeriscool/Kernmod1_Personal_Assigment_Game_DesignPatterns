using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyJumpState : State<int>
{
	GameObject Obj;
	public int SyncTime = 0; //Fixed update count till 30 for 1 sec
	Vector3 NewLocation;
	public EnemyJumpState(GameObject obj, string name, int id) : base(id,name) 
	{
		this.Name = name;//"Jump";
		Obj = obj;
	}
	
    public override void OnEnter()
	{
		Debug.Log("enter " + this.Name);
		Obj.GetComponent<Renderer>().material.color = Color.green;
		
	}
	public override void OnUpdate()
	{
		if(SyncTime >= 120) //4sec
		{
			float Y = 10; //height
			NewLocation = new Vector3(Random.Range(-5, 5), Y, Random.Range(-5, 5));
			SyncTime = 0;
		}
		
		Obj.transform.position = Vector3.MoveTowards(Obj.transform.localPosition,NewLocation,0.3f);
		
		if(NewLocation.y>= 1)
		{
			NewLocation += Vector3.down;
		}
		SyncTime++;
	}
	
	public override void OnExit()
	{
		Debug.Log("exit" + this.Name);
	}
}
