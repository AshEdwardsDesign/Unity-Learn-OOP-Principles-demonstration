using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Cube : Shape
{
    // POLYMORPHISM
    public override string GetDescription()
    {
        return $"I'm a cube! Points: {pointValue}";
    }
}
