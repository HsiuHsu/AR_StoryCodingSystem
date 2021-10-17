using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallQfive : MonoBehaviour
{
    GameObject Q5;
    Transform canvas;
    // Start is called before the first frame update
    void Start()
    {
        Q5 = Resources.Load<GameObject>("Q5");
        canvas = GameObject.Find("Canvas").transform;
        ////////////////
        Invoke("OpenQ5", 2f);
    }
    public void OpenQ5()
    {
        GameObject Q5temp = Instantiate(Q5, Vector3.zero, Quaternion.identity, canvas);
        Q5temp.transform.localPosition = new Vector3(0, 0, 0);
    }
}
