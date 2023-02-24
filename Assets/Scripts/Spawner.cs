using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject pinPrefab;
    public AudioSource PinLaunch;

    void Start()
    {
        PinLaunch = GetComponent<AudioSource>();
    }

    void Update() {
        if (Input.GetButtonDown("Fire1"))
        {
            SpawnPin();
            PinLaunch.Play();
        }
    }

    void SpawnPin() {
        Instantiate(pinPrefab, transform.position, transform.rotation);
    }
}
