using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallSeven : MonoBehaviour
{
    GameObject Q7;
    Transform canvas;
    // Start is called before the first frame update
    void Start()
    {
        Q7 = Resources.Load<GameObject>("Q7");
        canvas = GameObject.Find("Canvas").transform;
        ////////////////
        Invoke("OpenQ7", 2f);
    }
    public void OpenQ7()
    {
        GameObject Q7temp = Instantiate(Q7, Vector3.zero, Quaternion.identity, canvas);
        Q7temp.transform.localPosition = new Vector3(0, 0, 0);
    }
}
