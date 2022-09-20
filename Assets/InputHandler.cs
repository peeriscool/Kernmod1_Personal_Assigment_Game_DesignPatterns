using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler
{
	private GameObject Player;
	
	public InputHandler(GameObject _Player)
	{
		Player = _Player;
	}
	
	public KeyCode KeyReturn()
    {
	    if(Input.GetKeyDown(KeyCode.DownArrow))
	    {
		    Player.transform.position += Vector3.back;	
		    return KeyCode.DownArrow;
	    }
	    if(Input.GetKeyDown(KeyCode.LeftArrow))
	    {
		    Player.transform.position += Vector3.left;	
		    return KeyCode.LeftArrow;
	    }
	    if(Input.GetKeyDown(KeyCode.RightArrow))
	    {
		    Player.transform.position += Vector3.right;	
		    return KeyCode.RightArrow;
	    }
	    if(Input.GetKeyDown(KeyCode.UpArrow))
	    {
		    Player.transform.position += Vector3.forward ;	
		    return KeyCode.UpArrow;
	    }
	    return KeyCode.None;
    }
}
