﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    public Vector3 offset;


    private void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
        transform.position = player.position + offset;
    }
}
