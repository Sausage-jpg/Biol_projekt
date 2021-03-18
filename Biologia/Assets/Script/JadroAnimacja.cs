using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JadroAnimacja : MonoBehaviour
{
    public Animator animationController;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("console")) 
        {
            animationController.SetBool("onConsole", true);
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("console"))
        {
            animationController.SetBool("onConsole", false);
        }
    }
}
