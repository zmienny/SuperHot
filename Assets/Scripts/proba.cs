﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class proba : MonoBehaviour
{
    public Transform gracz;
    public float speed=1;
    

    void Start()
    {
    }

    private void FixedUpdate()
    {

    }

    void Update()
    {
        transform.position = Vector2.Lerp(transform.position, gracz.position, Time.timeScale *speed* moving.myTimeScale/100);
    }

}
