using System;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;

public class Spy
{
    public string StealFieldInfo(string investigatedCalss, params string[] requestedFields)
    {
        Type classType = Type.GetType(investigatedCalss);

        FieldInfo[] classFields =
            classType.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);

        StringBuilder sb = new StringBuilder();

        Object classInstance = Activator.CreateInstance(classType, new object[] { });

        sb.AppendLine($"Class under investigation: {investigatedCalss}");

        foreach (FieldInfo field in classFields.Where(f => requestedFields.Contains(f.Name)))
        {
            sb.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
        }
        return sb.ToString().Trim();
    }

    public string AnalyzeAcessModifiers(string className)
    {
        Type classType = Type.GetType(className);

        FieldInfo[] classFields =
            classType.GetFields(BindingFlags.Static | BindingFlags.Public | BindingFlags.Instance);

        MethodInfo[] classPublicMethods =
            classType.GetMethods(BindingFlags.Public | BindingFlags.Instance);

        MethodInfo[] classNonPublicmetods
            = classType.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);

        var sb = new StringBuilder();

        foreach (FieldInfo field in classFields)
        {
            sb.AppendLine($"{field.Name} must be private!");
        }

        foreach (MethodInfo method in classNonPublicmetods.Where(m => m.Name.StartsWith("get")))
        {
            sb.AppendLine($"{method.Name} have to be public!");
        }

        foreach (MethodInfo method in classPublicMethods.Where(x => x.Name.StartsWith("set")))
        {
            sb.AppendLine($"{method.Name} have to be private!");
        }

        return sb.ToString().Trim();
    }

    public string RevealPrivateMethods(string className)
    {
        Type classType = Type.GetType(className);
        MethodInfo[] privatemethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);
        var sb = new StringBuilder();

        sb.AppendLine($"All Private Methods of Class: {className}");
        sb.AppendLine($"Base Class: {classType.BaseType.Name}");

        foreach (MethodInfo method in privatemethods)
        {
            sb.AppendLine($"{method.Name}");
        }

        return sb.ToString().Trim();
    }

    public string CollectGettersAndSetters(string className)
    {
        Type classType = Type.GetType(className);

        MethodInfo[] allProperties = classType.GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static);

       var sb = new StringBuilder();

        foreach (MethodInfo methodGet in allProperties.Where(x=>x.Name.StartsWith("get")))
        {
            sb.AppendLine($"{methodGet.Name} will return {methodGet.ReturnType}");
        }

        foreach (MethodInfo methodGet in allProperties.Where(x => x.Name.StartsWith("set")))
        {
            sb.AppendLine($"{methodGet.Name} will return {methodGet.ReturnType}");
        }

        return sb.ToString().Trim();
    }
}