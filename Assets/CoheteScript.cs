﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoheteScript : MonoBehaviour
{
    float coheteSpeed = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        transform.Translate(0, coheteSpeed, 0);
    }
    public void despegue()
    {
        coheteSpeed = 0.1f;
        //debe activarse el objeto cohete fuego solo cuando se despegue
    }
