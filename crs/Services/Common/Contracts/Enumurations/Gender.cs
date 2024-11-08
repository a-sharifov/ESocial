namespace Contracts.Enumurations;

public sealed class Gender(string name, int value) : SmartEnum<Gender>(name, value)
{
    public static readonly Gender Male = new(nameof(Male), 0);
    public static readonly Gender Female = new(nameof(Female), 1);
    public static readonly Gender Undefined = new(nameof(Undefined), 2);
}
