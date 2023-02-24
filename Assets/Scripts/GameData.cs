using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameData : MonoBehaviour
{
    public Text GameNameText;
    public static float rotatorData;
    public static float pinData;
    //public DataManager KeepData;

    private void Awake()
    {
        GameNameText.text = DataManager.PlayerName;
        //rotatorData = Rotator.speed;
        //pinData = Pin.speed;
        //Rotator.Speed = SliderValues.Rotator;
        //Pin.Speed = SliderValues.PinValue;
    }
}
