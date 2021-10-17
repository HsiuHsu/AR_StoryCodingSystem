using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallTwelve : MonoBehaviour
{
    GameObject Q12;
    Transform canvas;
    // Start is called before the first frame update
    void Start()
    {
        Q12 = Resources.Load<GameObject>("Q12");
        canvas = GameObject.Find("Canvas").transform;
        ////////////////
        Invoke("OpenQ12", 2f);
    }

    public void OpenQ12()
    {
        GameObject Q12temp = Instantiate(Q12, Vector3.zero, Quaternion.identity, canvas);
        Q12temp.transform.localPosition = new Vector3(0, 0, 0);
    }
}
