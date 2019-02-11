﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed;
    float x, z;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        z = Input.GetAxis("Vertical") * Time.deltaTime * speed;

        transform.Translate(x, 0, z);
    }
}
