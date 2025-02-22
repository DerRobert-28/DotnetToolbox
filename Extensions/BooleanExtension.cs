namespace DerRobert28.DotnetToolbox.Extensions;

public static class BooleanExtension
{
	public static bool isFalse(this bool value) => value == false;
	public static bool isFalse(this bool? value) => value == false;

	public static bool isNotFalse(this bool value) => value != false;
	public static bool isNotFalse(this bool? value) => value != false;

	public static bool isNotTrue(this bool value) => value != true;
	public static bool isNotTrue(this bool? value) => value != true;

	public static bool isTrue(this bool value) => value == true;
	public static bool isTrue(this bool? value)	=> value == true;

	public static bool not(this bool value) => !value;
	public static bool? not(this bool? value) => value.whenNotNull(!value);
}
