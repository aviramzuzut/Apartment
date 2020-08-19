using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassDoorMotion : MonoBehaviour
{
    bool isOpen;
    Animator animator;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        isOpen = false;
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

     void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag =="RedKnight" /*|| other.gameObject.tag == "MainCamera"*/)
        {
            isOpen = true;
            animator.SetTrigger("GlassOpen");
            audioSource.Play();
        }
        
    }

    void OnTriggerExit(Collider other)
    {
        if(isOpen)
        {
            isOpen = false;
            animator.SetTrigger("GlassClose");
            audioSource.Play();
        }
    }
}
