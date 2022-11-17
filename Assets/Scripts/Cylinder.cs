using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Cylinder : Shape
{
    public Cylinder()
    {
        pointValue = 3;
    }
    // POLYMORPHISM
    public override string GetDescription()
    {
        return $"I'm a cylinder! Points: {pointValue}";
    }
}
