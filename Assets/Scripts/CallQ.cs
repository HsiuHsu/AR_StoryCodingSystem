using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallQ : MonoBehaviour
{
     GameObject Q1;
    Transform canvas;
    AudioSource successsound;
    // Start is called before the first frame update
    void Start()
    {
        Q1 = Resources.Load<GameObject>("Q1");
        canvas = GameObject.Find("Canvas").transform;
        ////////////////
        Invoke("OpenQ1", 2f);
    }
    public void OpenQ1()
    {
        GameObject Q1temp =  Instantiate(Q1, Vector3.zero, Quaternion.identity, canvas);
        Q1temp.transform.localPosition = new Vector3(0, 0, 0);
    }
}
