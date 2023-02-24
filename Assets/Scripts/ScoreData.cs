using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreData : MonoBehaviour
{
    public Text scoreText;

    private void Awake()
    {
        scoreText.text = ScoreManager.scoreText;
    }
}
