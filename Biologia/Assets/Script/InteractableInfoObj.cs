using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractableInfoObj : MonoBehaviour
{
    Renderer renderer;
    Color selectedColor, baseColor;
   [SerializeField] public string infoText;
    void Start()
    {
        renderer = GetComponent<Renderer>();
        baseColor = renderer.material.color;
        selectedColor = new Color(renderer.material.color.r + 0.1f,
                                  renderer.material.color.g + 0.1f,
                                  renderer.material.color.b + 0.1f);
    }

    void Update()
    {
        ChangeMaterial(baseColor);
        DisplayInfoPanel(false);
    }

    public void DrawInfo()
    {
        Debug.Log("Zglaszam interackje " + this.name);
        ChangeMaterial(selectedColor);
        DisplayInfoPanel(true);

    }

    void ChangeMaterial(Color newColor)
    {
        renderer.material.color = newColor;
    }

    void DisplayInfoPanel(bool setActive)
    { 
        //setActiveTRUE or FAlSE;
        
    }
}
