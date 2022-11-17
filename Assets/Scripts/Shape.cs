using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    // ENCAPSULATION
    public int pointValue { get; protected set; } = 0;
    abstract public string GetDescription();
}
