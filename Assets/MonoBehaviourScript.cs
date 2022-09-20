using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonoBehaviourScript : MonoBehaviour
{
	public GameObject Player;
	InputHandler handler;
	private Commander mycommander;
	//Receiver receiver = new Receiver();
	CommandPatternA A;
	CommandPatternB B;
	bool command = false;
	IcommandRecorder Recorder = new IcommandRecorder();
	
    void Start()
	{
		handler = new InputHandler(Player);
		A = new CommandPatternA(Player,Vector3.up);
		B = new CommandPatternB(Player,"Cube");
	    mycommander = new Commander();  
		 mycommander.SetOnstart(A);
		 mycommander.SetOnexit(B);
		// mycommander.RunstartExit();
		Recorder.Record(A);
    } 

    void Update()
	{
		handler.KeyReturn();
	    
		if(Input.GetKeyUp(KeyCode.A))
	    {
			mycommander.CommandFromList(B);
	    }
	    if(Input.GetKeyDown(KeyCode.S))
	    {
	    	
	    }
	}
    
}
