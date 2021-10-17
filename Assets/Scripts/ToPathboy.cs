using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToPathboy : MonoBehaviour
{
    Button Btn;
    Animator playerAnim;
   // AudioSource sound;
    // Start is called before the first frame update
    void Start()
    {
        playerAnim = GameObject.FindGameObjectWithTag("pathboy").GetComponent<Animator>();
        //sound = GameObject.FindGameObjectWithTag("Success_sound").GetComponent<AudioSource>();
        Btn = GetComponent<Button>();
        Btn.onClick.AddListener(PlayAnim);
        //Btn.onClick.AddListener(Playsound);
    }

    private void PlayAnim()
    {
        playerAnim.SetTrigger("pathboy");
    }
   /* private void Playsound()
    {
        sound.Play();
    }*/
}
