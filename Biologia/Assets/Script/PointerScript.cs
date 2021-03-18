using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointerScript : MonoBehaviour
{
    [SerializeField] private string selectableTag = "selectable"; 
   // public Colorable colorableScript;

    public LineRenderer laser;  
    public  bool isOn;
    private GameObject selectedObject;


    private void Awake()
    {
        isOn = false;
    }

   
    void Update()
    {     
        laser.enabled = false;
        if (OVRInput.GetDown(OVRInput.Button.One))
        {
            isOn = !isOn;
        }
        
        if (isOn)
        {
            Vector3 dir = (this.gameObject.transform.right) * -1;
            Debug.DrawRay(this.transform.position, dir, Color.red, 2.5f);
            laser.enabled = true;
            laser.SetPosition(0, this.transform.position);
            laser.SetPosition(1, this.transform.position + ((this.transform.right) * -1));
            Ray ray = new Ray(this.transform.position, ((this.transform.right) * -1) * Time.deltaTime);
            RaycastHit hit;

            if (Physics.Raycast(ray,out hit,8))
            {             
                
                if (hit.collider.CompareTag("selectable"))
                {                                       
                    hit.transform.gameObject.GetComponent<Colorable>().OnRay();                   
                }              
                               
            }
           
      

        }      
       
        
    }

   
}
