using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallQfour : MonoBehaviour
{
    GameObject Q4;
    Transform canvas;
    // Start is called before the first frame update
    void Start()
    {
        Q4 = Resources.Load<GameObject>("Q4");
        canvas = GameObject.Find("Canvas").transform;
        ////////////////
        Invoke("OpenQ4", 2f);
    }
    public void OpenQ4()
    {
        GameObject Q4temp = Instantiate(Q4, Vector3.zero, Quaternion.identity, canvas);
        Q4temp.transform.localPosition = new Vector3(0, 0, 0);
    }
}

