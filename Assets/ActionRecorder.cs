using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IcommandRecorder
{
	private Stack<IcommandContainer> CommandStack = new	Stack<IcommandContainer>();
	public void Record(Icommand _Action)
	{
		IcommandContainer data = new IcommandContainer();
		data.assign(_Action);
	    data.Execute();
	    CommandStack.Push(data);
    }
 
	void Rewind()
	{
		//CommandStack.Peek();
		//  PopStack();
    }
	void PushStack(IcommandContainer _Item)
	{
		CommandStack.Push(_Item);
	}
	IcommandContainer PopStack()
	{
		return CommandStack.Pop();
	}
}

public class IcommandContainer:Icommand
{
	Icommand Command;
	public	void Execute()
	{
		Command.Execute();
	}
	public void assign(Icommand _command)
	{
		Command = _command;
	}
}
public abstract class IcommandnBase
{
	protected readonly GameObject Obj;
	
	protected IcommandnBase(GameObject _obj)
	{
		Obj = _obj;
	}
}