namespace DerRobert28.DotnetToolbox.Extensions;

public static class StringExtension
{
	public static string asString<T>(this T? value)
		=> value.whenNull(string.Empty, $"{value}");
}
