using Sandbox;

public class SBot : Bot
{
	[ConCmd.Admin( "sbot", Help = "Spawn SBot bot." )]
	internal static void SpawnCustomBot()
	{
		Game.AssertServer();

		// Create an instance of your custom bot.
		_ = new SBot();
	}

	public override void BuildInput()
	{
		// Here we can choose / modify the bot's input each tick.
		// We'll make them constantly attack by holding down the PrimaryAttack button.
		Input.SetButton( InputButton.PrimaryAttack, true );
	}

	/*
	public override void Tick()
	{
		// Here we can do something with the bot each tick.
		// Here we'll print our bot's name every tick.
		Log.Info( Client.Name );
	}
	*/
}
