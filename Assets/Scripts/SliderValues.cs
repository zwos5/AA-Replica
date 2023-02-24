using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderValues : MonoBehaviour
{
    public Slider RotatorSlider; 
    public Text RotatorSliderText;

    public Slider PinSlider;
    public Text PinSliderText;

    public static float Rotator;
    public static float PinValue;

    // Update is called once per frame
    void Update()
    {
        Rotator = RotatorSlider.value;
        RotatorSliderText.text = Rotator.ToString("f0");

        PinValue = PinSlider.value;
        PinSliderText.text = PinValue.ToString("f0");
    }
}
