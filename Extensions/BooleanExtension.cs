namespace DerRobert28.DotnetToolbox.Extensions;

public static class BooleanExtension
{
	public static bool and(this bool first, bool second)
	{
		if (!first) return false;
		return second;
	}

	public static bool andAlso(this bool first, bool second) => first && second;
		
	public static bool but(this bool first, bool second) => first.and(second);
	
	public static bool butNot(this bool first, bool second) => first.but(second.not());

	public static bool equ(this bool first, bool second) => first == second;
	
	public static bool imp(this bool first, bool second) => !first || second;

	public static bool isFalse(this bool value) => !value;
	public static bool isFalse(this bool? value) => value == false;

	public static bool isNotFalse(this bool value) => value;
	public static bool isNotFalse(this bool? value) => value != false;

	public static bool isNotTrue(this bool value) => !value;
	public static bool isNotTrue(this bool? value) => value != true;

	public static bool isTrue(this bool value) => value;
	public static bool isTrue(this bool? value) => value == true;

	public static bool not(this bool value) => !value;
	
	public static bool or(this bool first, bool second)
	{
		if (first) return true;
		return second;
	}

	public static bool orElse(this bool first, bool second) => first || second;

	public static bool xor(this bool first, bool second) => first != second;
}
