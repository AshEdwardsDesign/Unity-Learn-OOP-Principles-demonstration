using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Sphere : Shape
{
    public Sphere()
    {
        pointValue = 2;
    }
    // POLYMORPHISM
    public override string GetDescription()
    {
        return $"I'm a sphere! Points: {pointValue}";
    }
}
