using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotatorColor : MonoBehaviour
{
    public Material RedRotator;
    public Material GreenRotator;
    public Material BlueRotator;
    public Material BlackRotator;
    public GameObject Rotator;
    public Dropdown ColorDropdown;
  

    void Update()
    {
        switch (ColorDropdown.value)
        {
            case 0:
                Rotator.GetComponent<Renderer>().material = BlackRotator;
                break;

            case 1:
                Rotator.GetComponent<Renderer>().material = RedRotator;
                //new Color(255f, 0f, 0f, 255f);
                //SpriteRenderer.color = new Color(255f, 0f, 0f, 255f); 
                break;

            case 2:
                Rotator.GetComponent<Renderer>().material = GreenRotator;
                break;

            case 3:
                Rotator.GetComponent<Renderer>().material = BlueRotator;
                break;
        }

    }
}
