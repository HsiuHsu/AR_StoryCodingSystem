using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calleleven : MonoBehaviour
{
    GameObject Q11;
    Transform canvas;

    // Start is called before the first frame update
    void Start()
    {
        Q11 = Resources.Load<GameObject>("Q11");
        canvas = GameObject.Find("Canvas").transform;
        ////////////////
        Invoke("OpenQ11", 2f);
    }
    public void OpenQ11()
    {
        GameObject Q11temp = Instantiate(Q11, Vector3.zero, Quaternion.identity, canvas);
        Q11temp.transform.localPosition = new Vector3(0, 0, 0);
    }
}
