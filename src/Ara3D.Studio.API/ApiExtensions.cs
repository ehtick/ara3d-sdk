﻿namespace Ara3D.Studio.API;

public static class ApiExtensions
{
    public static IModelGenerator CreateDefault(this IModelGenerator self)
        => Activator.CreateInstance(self.GetType()) as IModelGenerator
           ?? throw new Exception($"Failed to make a copy of {self}");

    public static IModelModifier CreateDefault(this IModelModifier self)
        => Activator.CreateInstance(self.GetType()) as IModelModifier
           ?? throw new Exception($"Failed to make a copy of {self}");
}