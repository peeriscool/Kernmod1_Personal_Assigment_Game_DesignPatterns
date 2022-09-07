using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Timers;
using System;

public class DefaultState : State
{
	protected StateMachine Owner;
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

    }
    public override void OnUpdate()
    {
	    Debug.Log("Updatecalls" + Count);
	    //  InitTimer();
	    Count++;
	    GameObject test = GameObject.Instantiate(GameObject.CreatePrimitive(PrimitiveType.Cube));
	    test.transform.position = new Vector3(Count,0,0);
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
