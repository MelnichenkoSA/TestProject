using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IRangeWeapon : IWeapon
{
    void Scope()
    {
        Debug.Log("I scoping!");
    }
}
