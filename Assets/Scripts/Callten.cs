using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Callten : MonoBehaviour
{
    GameObject Q10;
    Transform canvas;
    // Start is called before the first frame update
    void Start()
    {
        Q10 = Resources.Load<GameObject>("Q10");
        canvas = GameObject.Find("Canvas").transform;
        ////////////////
        Invoke("OpenQ10", 2f);
    }
    public void OpenQ10()
    {
        GameObject Q10temp = Instantiate(Q10, Vector3.zero, Quaternion.identity, canvas);
        Q10temp.transform.localPosition = new Vector3(0, 0, 0);
    }
}
