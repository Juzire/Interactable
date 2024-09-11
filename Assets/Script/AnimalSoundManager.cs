using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalSoundManager : MonoBehaviour
{
    public GameObject[] animals;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < animals.Length; i++)
        {
            if (animals[i].name == ("Cat"))
            {
                Debug.Log("MEOW");
            }
            else if (animals[i].name == ("Dog"))
            {
                Debug.Log("ARF");
            }    
            else if (animals[i].name == ("Cow"))
            {
                Debug.Log("MOO");
            }
            else if (animals[i].name == ("Bird"))
            {
                Debug.Log("Tweet");
            }
            else if (animals[i].name == ("Fish"))
            {
                Debug.Log("Gawk");
            }else
            {
                Debug.Log("Not yet recorded");
            }
        }
    }

}    
