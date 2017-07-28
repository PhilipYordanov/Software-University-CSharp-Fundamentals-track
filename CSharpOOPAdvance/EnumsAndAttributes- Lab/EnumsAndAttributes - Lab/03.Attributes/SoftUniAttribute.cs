﻿using System;
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.All, AllowMultiple = true)]
public class SoftUniAttribute : Attribute
{
    public SoftUniAttribute(string name)
    {
        this.Name = name;
    }

    public string Name { get; set; }
}