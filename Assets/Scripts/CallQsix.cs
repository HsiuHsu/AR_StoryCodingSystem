using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallQsix : MonoBehaviour
{
    GameObject Q6;
    Transform canvas;
    // Start is called before the first frame update
    void Start()
    {
        Q6 = Resources.Load<GameObject>("Q6");
        canvas = GameObject.Find("Canvas").transform;
        ////////////////
        Invoke("OpenQ6", 2f);
    }
    public void OpenQ6()
    {
        GameObject Q6temp = Instantiate(Q6, Vector3.zero, Quaternion.identity, canvas);
        Q6temp.transform.localPosition = new Vector3(0, 0, 0);
    }
}
