﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KretanjeCeste : MonoBehaviour
{
    public float speed;
    Vector2 offset;

    private void Start()
    {
        
    }

    private void Update()
    {
        offset = new Vector2(0, Time.time * speed);
        GetComponent<Renderer>().material.mainTextureOffset = offset;
    }
}
