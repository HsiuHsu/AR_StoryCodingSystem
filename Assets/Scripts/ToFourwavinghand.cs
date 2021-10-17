using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ToFourwavinghand : MonoBehaviour
{
    Button Btn;
    Animator playerAnim;
    Animator playerAnim2;
    // Start is called before the first frame update
    void Start()
    {
        playerAnim = GameObject.FindGameObjectWithTag("playWavinghand").GetComponent<Animator>();
        playerAnim2 = GameObject.FindGameObjectWithTag("playGirlwave").GetComponent<Animator>();
        Btn = GetComponent<Button>();
        Btn.onClick.AddListener(PlayAnim);
    }

    private void PlayAnim()
    {
        playerAnim.SetTrigger("fourwavinghand");
        playerAnim2.SetTrigger("girlwave");
    }

}