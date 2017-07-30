using System;

[AttributeUsage(AttributeTargets.Enum, AllowMultiple = true,Inherited = false)]
public class TypeAttribute : Attribute
{
    public string Type { get; set; }
    public string Category { get; set; }
    public string Description { get; set; }

    public TypeAttribute(string type, string category, string description)
    {
        this.Type = type;
        this.Category = category;
        this.Description = description;
    }

    public override string ToString()
    {
        return $"Type = {this.Type}, Description = {this.Description}";
    }
}