using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Timers;
using System;

public class DefaultState : State
{
	protected StateMachine Owner;
	GameObject test; //cube for testing
	//  public event EventHandler Tick;
	int Count = 0;
	public DefaultState(StateMachine _owner)
    {
	    this.Owner = _owner;
    }


	public void Init(StateMachine _owner)
    {
	    this.Owner = _owner;
    }

    public override void OnEnter()
    {
	     test = GameObject.Instantiate(GameObject.CreatePrimitive(PrimitiveType.Cube));
    }
    public override void OnUpdate()
    {
	    Debug.Log("Update_calls" + Count);
	    Count++;
	    test.transform.position = new Vector3(Mathf.Sin(Count),0,0);
	    //  InitTimer();
    }
    public override void OnExit()
    {

    }

    //public void InitTimer()
    //{
    //    Timer timer1 = new Timer
    //    {
    //        Interval = 2000
    //    };
    //    timer1 = new System.Timers.Timer(2000);
    //    timer1.Elapsed += OnTimerEvent;
    //    timer1.Enabled = true;
    //}

    //public static void OnTimerEvent(object source, EventArgs e)
    //{ 
    //   System.Random a = new System.Random();
    //    Debug.Log(a);
    //}
}
