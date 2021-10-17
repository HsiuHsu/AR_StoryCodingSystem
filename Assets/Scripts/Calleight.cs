using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calleight : MonoBehaviour
{
    GameObject Q8;
    Transform canvas;

    // Start is called before the first frame update
    void Start()
    {
        Q8 = Resources.Load<GameObject>("Q8");
        canvas = GameObject.Find("Canvas").transform;
        ////////////////
        Invoke("OpenQ8", 2f);
    }
    public void OpenQ8()
    {
        GameObject Q8temp = Instantiate(Q8, Vector3.zero, Quaternion.identity, canvas);
        Q8temp.transform.localPosition = new Vector3(0, 0, 0);
    }
}
