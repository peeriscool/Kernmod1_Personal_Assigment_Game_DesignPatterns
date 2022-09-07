using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//https://refactoring.guru/design-patterns/command/csharp/example

	
	//declare a method for executing a command
	public interface Icommand
	{
	 void Execute();
	};
	public class CommandPatternA : Icommand
	{
	//the command and it's related data and functions

			private string payload = string.Empty;
			private Vector3 location = Vector3.zero;		
			public CommandPatternA(string _payload, Vector3 loc)
			{
				this.payload = _payload;
				this.location = loc;
			}
			public void Execute()
			{
			Debug.Log("CommandA");
				Debug.Log(payload);
				Debug.Log(location);
			}
		
	}
	public class CommandPatternB : Icommand
	{
		private Receiver receiver;

		// Context data, required for launching the receiver's methods.
		private string a;

		private string b;

		// Complex commands can accept one or several receiver objects along
		// with any context data via the constructor.
		public CommandPatternB(Receiver _receiver, string _a, string _b)
		{
			this.receiver = _receiver;
			this.a = _a;
			this.b = _b;
		}

		// Commands can delegate to any methods of a receiver.
		
		public void Execute()
		{
			Debug.Log("CommandB.");
			this.receiver.DoSomething(this.a);
			this.receiver.DoSomethingElse(this.b);
		}
	}
	public class Receiver
	{
		public void DoSomething(string a)
		{
			Debug.Log($"Receiver: Working on ({a}.)");
		}

		public void DoSomethingElse(string b)
		{
			Debug.Log($"Receiver: Also working on ({b}.)");
		}
	}
