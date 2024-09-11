using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public abstract class AnimalSound : MonoBehaviour
{
   public virtual void MakeSound()
    {
        Debug.Log("Generic Sound");
    }
}
