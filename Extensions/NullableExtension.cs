namespace DerRobert28.DotnetToolbox.Extensions;

#region Usings

using System.Diagnostics.CodeAnalysis;

#endregion

public static class NullableExtension
{
	public static bool isNotNull<T>([NotNullWhen(true)] this T? value)
		=> value is not null;

	public static bool isNull<T>([NotNullWhen(false)] this T? value)
		=> value is null;

	public static string toString<T>(this T? value)
		=> value?.ToString() ?? "null";

	public static T? whenNotNull<T>([NotNullWhen(true)] this T? first, T second)
		=> first.isNotNull()? first: second;
	public static U whenNotNull<T, U>([NotNullWhen(true)] this T? value, U first, U second)
		=> value.isNotNull()? first: second;

	public static T whenNull<T>([NotNullWhen(false)] this T? first, T second)
		=> first ?? second;
	public static U whenNull<T, U>([NotNullWhen(false)] this T? value, U first, U second)
		=> value.isNull()? first: second;
}
