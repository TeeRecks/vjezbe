using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoSpawner : MonoBehaviour
{
    public GameObject[] Cars;
    int CarNo;
    public float maxPos = 2.45f;
    public float delayTimer = 1f;
    float timer;

    private void Start()
    {
        timer = delayTimer;
    }

    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Vector3 carPos = new Vector3(Random.Range(2.45f, -2.45f), transform.position.y, transform.position.z);
            CarNo = Random.Range(0, 5);
            Instantiate(Cars[CarNo], carPos, transform.rotation);
            timer = delayTimer;
        }
    }
}
