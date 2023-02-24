using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    /* Start is called before the first frame update
    void Start()
    {
        
    }*/

    public float speed = 100f;

    void Update() {
        speed = DataManager.rotatorData;
        transform.Rotate(0f, 0f, speed * Time.deltaTime);
    }

}
