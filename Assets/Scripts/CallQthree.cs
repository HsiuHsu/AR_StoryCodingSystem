using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallQthree : MonoBehaviour
{
    GameObject Q3;
    Transform canvas;
    // Start is called before the first frame update
    void Start()
    {
        Q3 = Resources.Load<GameObject>("Q3");
        canvas = GameObject.Find("Canvas").transform;
        ////////////////
        Invoke("OpenQ3", 2f);
    }
    public void OpenQ3()
    {
        GameObject Q3temp = Instantiate(Q3, Vector3.zero, Quaternion.identity, canvas);
        Q3temp.transform.localPosition = new Vector3(0, 0, 0);
    }
}
