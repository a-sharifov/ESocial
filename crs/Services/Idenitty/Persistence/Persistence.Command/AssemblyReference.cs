using System.Reflection;

namespace Persistence.Command;

public static class AssemblyReference
{
    public static Assembly Assembly => typeof(AssemblyReference).Assembly;
}

