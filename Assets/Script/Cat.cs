using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : AnimalSound
{
    void Start()
    {
        MakeSound();
    }

    public override void MakeSound()
    {
        Debug.Log("Meow");
    }
}
