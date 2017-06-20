﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCube : MonoBehaviour
{
    private bool stop;
    void Update()
    {
        if (!stop)
            transform.Rotate(new Vector3(1, 1, 1));
    }


    [Command("stop-cube", "stops the cube from rotating")]
    public void StopCube()
    {
        stop = true;
    }


    [Command("rotate-cube", "rotates the cube")]
    public void RotateTheCube()
    {
        stop = false;
    }
}
