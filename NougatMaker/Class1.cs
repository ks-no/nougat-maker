namespace NougatMaker;

using System.Reflection;

public class Class1
{
    public static Stream? GetResourceStream(string resourceName)
    {
        var assembly = Assembly.GetExecutingAssembly();
        // Example: "NougatMaker.Resources.NougatChristmassy.jpeg"
        return assembly.GetManifestResourceStream($"NougatMaker.Resources.{resourceName}");
    }
}
