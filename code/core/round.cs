using Sandbox;
using System;
using System.Threading;
using System.Threading.Tasks;

[ClassLibrary("prophunt", Title = "PropHunt")]
static partial class PropHuntRound : Game
{
	private bool isStarted = false; 

	public static PropHuntRound()
	{

	}

	public async static Task StartRound(float Time)
    {
		if (isStarted)
			return;


    }
}