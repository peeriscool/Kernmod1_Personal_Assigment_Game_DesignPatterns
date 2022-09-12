using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonoBehaviourScript : MonoBehaviour
{
	private Commander mycommander;
	Receiver receiver = new Receiver();
	CommandPatternA A;
	CommandPatternB B;
    void Start()
	{
		A = new CommandPatternA("command_name",Vector3.up);
		B = new CommandPatternB(receiver,"data","stuff");
	    mycommander = new Commander();  
	    mycommander.SetOnstart(A);
	    mycommander.SetOnexit(B	);
	    mycommander.RunstartExit();
    } 
	

    
    void Update()
    {
	    if(Input.GetKeyDown(KeyCode.A))
	    {
	    	Debug.Log("Pressed A: ");
	    	mycommander.CommandFromList(A);
	    }
    }
}
