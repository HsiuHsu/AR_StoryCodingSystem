using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ToClapAnim : MonoBehaviour
{
    Button Btn;
    Animator playerAnim;
    AudioSource sound;
    // Start is called before the first frame update
    void Start()
    {
        playerAnim = GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>();
        //sound = GameObject.FindGameObjectWithTag("Success_sound").GetComponent<AudioSource>();
        Btn = GetComponent<Button>();
        Btn.onClick.AddListener(PlayAnim);
       // Btn.onClick.AddListener(Playsound);
    }

    private void PlayAnim()
    {
        playerAnim.SetTrigger("clap4");
    }
    /*private void Playsound()
    {
        sound.Play();
    }*/
}
