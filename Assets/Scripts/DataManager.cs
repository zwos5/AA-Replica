using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataManager : MonoBehaviour
{
    public static string PlayerName;
    public InputField PlayerNameInput;
    public Text showPlayerName;

    public static float rotatorData;
    public Slider Rotator;
    public Text RotatorSpeedTxt;

    public static float pinData;
    public Slider PinSlider;
    public Text PinText;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void UpdateName() 
    {
        PlayerName = showPlayerName.text;  
    }

    public void ShowName() 
    {
        showPlayerName.text = PlayerName;
        
    }

    public void RotatorSpeed()
    {
        rotatorData = SliderValues.Rotator;
    }

    public void PinSpeed()
    {
        pinData = SliderValues.PinValue;
    }
}
