using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
    private bool isPinned = false;

    public static float speed = 20f;
    public Rigidbody2D rb;

    void Start()
    {
        speed = DataManager.pinData;
    }
    void Update() {
        if(!isPinned)
            rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D col) {
        if (col.tag == "Rotator")
        {
            transform.SetParent(col.transform);
            //col.GetComponent<Rotator>().speed *= -1; Reverse rotator when pin hits it.
            Score.PinCount++;
            isPinned = true;
        }
        else if (col.tag == "Pin")
        {
            //End Game
            //Debug.Log("End Game");
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
