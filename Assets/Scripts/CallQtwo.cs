using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallQtwo : MonoBehaviour
{
    GameObject Q2;
    Transform canvas;
    // Start is called before the first frame update
    void Start()
    {
        Q2 = Resources.Load<GameObject>("Q2");
        canvas = GameObject.Find("Canvas").transform;
        ////////////////
        Invoke("OpenQ2", 2f);
    }
    public void OpenQ2()
    {
        GameObject Q2temp = Instantiate(Q2, Vector3.zero, Quaternion.identity, canvas);
        Q2temp.transform.localPosition = new Vector3(0, 0, 0);
    }
}