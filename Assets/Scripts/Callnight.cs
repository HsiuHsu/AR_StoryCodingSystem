using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Callnight : MonoBehaviour
{
    GameObject Q9;
    Transform canvas;

    // Start is called before the first frame update
    void Start()
    {
        Q9 = Resources.Load<GameObject>("Q9");
        canvas = GameObject.Find("Canvas").transform;
        ////////////////
        Invoke("OpenQ9", 2f);
    }

    // Update is called once per frame

    public void OpenQ9()
    {
            GameObject Q9temp = Instantiate(Q9, Vector3.zero, Quaternion.identity, canvas);
            Q9temp.transform.localPosition = new Vector3(0, 0, 0);
    }

}
