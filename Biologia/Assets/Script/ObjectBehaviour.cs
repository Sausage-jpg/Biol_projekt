using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectBehaviour : MonoBehaviour
{
    private Vector3 defaultPos;
    private Quaternion defaultRot;
    private bool isGrabbed;

    public  Animator animatorController;
    private OVRGrabbable ovrGrabScript;
   
    //private Transform defaultTransform;
    
    // Start is called before the first frame update
    void Awake()
    {
        defaultPos = this.gameObject.transform.position;
        defaultRot = this.gameObject.transform.rotation;
        ovrGrabScript = this.gameObject.GetComponent<OVRGrabbable>();
       
    }

    // Update is called once per frame
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("floor"))
        {

            this.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            this.gameObject.transform.position = defaultPos;
            this.gameObject.transform.rotation = defaultRot;
             
           

        }
        if (other.CompareTag("console") && isGrabbed == false)
        {
            animatorController.enabled = true;
            //Debug.Log(this.name + " is on the console");
            animatorController.SetBool("OnConsole", true);

        }
        if (isGrabbed == true)
        {
            animatorController.enabled = false;
            animatorController.SetBool("OnConsole", false);
            
        }
    }
    private void Update()
    {
        isGrabbed = ovrGrabScript.isReallyGrabbed;
        //Debug.Log(isGrabbed);
    }


}
