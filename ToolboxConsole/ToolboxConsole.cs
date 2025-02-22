namespace DerRobert28.DotnetToolbox.ToolboxConsole;

#region Usings

using DerRobert28.DotnetToolbox.Extensions;

#endregion

internal class ToolboxConsole {

	#region Main Method

	public static void Main() {
		int?	x = null;
		//
		Console.WriteLine(x.asString());
		Console.WriteLine(x.toString());
		//
		Console.ReadLine();
	}

	#endregion
}
