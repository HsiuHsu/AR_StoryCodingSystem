using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AudioSource successsound;
        successsound = Resources.Load<AudioSource>("successsd");
        successsound.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
