using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class watchBehaviour : MonoBehaviour
{
    public Text placeInfo;
    public Text placeInfo2;
    public Text placeInfo3;
    public Text clockTime;
    //  public int pos;
    public Dropdown dropdown;
   

    // Start is called before the first frame update



    private void Start()
    {
        dropdown.onValueChanged.AddListener(EnableInfo);
        
    }
    private void Update()
    {
       
        DateTime time = DateTime.Now;
        string hour = time.Hour.ToString();
        string minute = time.Minute.ToString();
        clockTime.text = hour + ":" + minute;
    }

    public  void EnableInfo(int val)
    {
        switch (val)
        {
            case 0:
                Debug.Log("WLACZANIE TEKSTU");
                placeInfo.gameObject.SetActive(true);
                placeInfo2.gameObject.SetActive(false);
                placeInfo3.gameObject.SetActive(false);
                Debug.Log("XDD");
                break;
            case 1:
                placeInfo.gameObject.SetActive(false);
                placeInfo2.gameObject.SetActive(true);
                placeInfo3.gameObject.SetActive(false);
                break;
            case 2:
                placeInfo.gameObject.SetActive(false);
                placeInfo2.gameObject.SetActive(false);
                placeInfo3.gameObject.SetActive(true);
                break;
        }

    }
        
}
