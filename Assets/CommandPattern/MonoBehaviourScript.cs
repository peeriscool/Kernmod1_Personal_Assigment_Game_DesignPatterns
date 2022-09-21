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
	
	WASDCommands Command = new WASDCommands();
	ArrowCommands AltCommand = new ArrowCommands();
	bool command = false;
	IcommandRecorder Recorder = new IcommandRecorder();
	
    void Start()
	{
		handler = new InputHandler(Player);
		handler.SetHandler(Command);
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
		
		if(Input.GetKeyUp(KeyCode.E))
	    {
			mycommander.CommandFromList(B);
	    }
	    
		if(Input.GetKeyUp(KeyCode.LeftShift))
		{
			if(command)
			{
				Debug.Log("Set arrow");
				handler.SetHandler(AltCommand);
				command = false;
				return;
			}
			if(!command)
			{
				Debug.Log("Set WASD");
				handler.SetHandler(Command);
				command = true;
			}
			
		}
	    
	    
	}
	//https://docs.unity3d.com/ScriptReference/Event-keyCode.html
	void OnGUI()
	{
		Event e = Event.current;
		if (e.isKey)
		{
			handler.HandleInput(e.keyCode);
		}
	}
    
}
