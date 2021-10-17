using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIBarEvent : MonoBehaviour
{
    public GameObject BackButton;
    public GameObject OpenButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BarOpen()
    {
        GetComponent<Animator>().SetBool("Open", true);
        OpenButton.GetComponent<Button>().enabled = false;
    }
    public void BarClose()
    {
        GetComponent<Animator>().SetBool("Close", true);
        OpenButton.GetComponent<Button>().enabled = true;
    }
    public void BarEndClose()
    {
        GetComponent<Animator>().SetBool("EndClose", true);
        OpenButton.transform.localScale = new Vector3(1f, 1f, 1f);
        OpenButton.GetComponent<Image>().color = new Vector4(1f, 1f, 1f, 1f);
    }
    public void BarCloseButton()
    {
        BackButton.SetActive(true);
    }
    public void BarOpenButtonColor()
    {
        OpenButton.transform.localScale = new Vector3(0.9f, 0.9f, 0.9f);
        OpenButton.GetComponent<Image>().color = new Vector4(0.8f, 0.8f, 0.8f, 0.7f);
    }
}
