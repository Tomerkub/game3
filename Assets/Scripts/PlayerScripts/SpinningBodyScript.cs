﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningBodyScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f,Input.GetAxis("Mouse X"),0f);
    }
}
