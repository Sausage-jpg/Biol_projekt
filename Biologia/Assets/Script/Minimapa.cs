using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Minimapa : MonoBehaviour
{
    private bool isOn;
    public GameObject min;
    // Start is called before the first frame update
    void Start()
    {

        isOn = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.Four))
        {
            isOn = !isOn;
            //Debug.Log("MINIMAPA ON");
            min.SetActive(isOn);
        }
    }
}
