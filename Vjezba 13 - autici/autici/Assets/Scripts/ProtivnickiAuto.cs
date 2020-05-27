using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProtivnickiAuto : MonoBehaviour
{
    public float EcarSpeed = 5f;

    private void Start()
    {
        
    }

    private void Update()
    {
        transform.Translate(new Vector3(0, 1, 0) * EcarSpeed * Time.deltaTime);
    }
}
