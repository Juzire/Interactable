using System.Collections;
using System.Collections.Generic;
using jbmedina;
using UnityEngine;
using UnityEngine.UI;

public class TV : MonoBehaviour, IInteractable
{
    public GameObject TVon;

    public void Toggle()
    {
        TVon.SetActive(true);
    }

    public void Interact()
    {
        Toggle();
    }
}
