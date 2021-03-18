using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colorable : MonoBehaviour
{
    public  Renderer rend;    
    public GameObject tekst;
   
    Color baseColor, selectedColor;
    
    void Start()
    {
        rend = this.gameObject.GetComponent<Renderer>();
        baseColor = rend.material.color;
        selectedColor = new Color(rend.material.color.r + 0.1f, rend.material.color.g + 0.1f, rend.material.color.b + 0.1f);
        
    }

    
    void Update()
    {
        tekst.SetActive(false);
        ChangeColor(baseColor);
    }
  
    public  void ChangeColor(Color color)
    {
      //  Debug.Log("Teraz zmieniamy kolor" + color);
        rend.material.color = color;
    }

    public void OnRay()
    {
       // Debug.Log("Interakcja"+ this.gameObject.name);
        ChangeColor(selectedColor);
        tekst.SetActive(true);
    }

    

}
