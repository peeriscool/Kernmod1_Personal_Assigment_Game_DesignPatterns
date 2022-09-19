using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnvoirment
{
	
	LinkedList<Block> blocks = new LinkedList<Block>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
	void MakeSurface(int Size)
    {
	    for (int i = 0; i < Size; i++)
	    {
		    Block block = new Block();
	    }
    }
}
public class Block
{
   //static Transform parent;
	//GameObject cube = GameObject.Instantiate(PrimitiveType.Cube, parent);
	public Block()
	{
		//init
	}
	
}
