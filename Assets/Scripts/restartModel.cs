using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class restartModel : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject []go;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void onClickOpen() {
        for (int i = 0; i < go.Length; i++)
            go[i].SetActive(true);
    }
    public void onClickClose()
    {
        for (int i = 0; i < go.Length; i++)
            go[i].SetActive(false);
    }

}
