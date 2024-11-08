using Vogen;

[assembly: VogenDefaults(
    underlyingType: typeof(int),
    conversions: Conversions.Default,
    throws: typeof(ValueObjectValidationException))]