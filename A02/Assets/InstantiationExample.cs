﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiationExample : MonoBehaviour
{
    // Reference to the Prefab. Drag a Prefab into this field in the Inspector.
    public GameObject prefab;

    // This script will simply instantiate the Prefab when the game starts.
    void Start()
    {
    // Instantiate at position (0, 0, 0) and zero rotation.
    //Instantiate(prefab, new Vector3(0, 0, 0), Quaternion.identity);
        for (int i = 0; i < 5; i++)
            for (int j = 0; j < 2; j++)
            {
                Instantiate(prefab, new Vector3(i * 0.5f, j*0.5f, 10), Quaternion.identity);
            }
    }
    //void Update()
    //{

    //}
    /*public int numberOfObjects = 20;
    public float radius = 3f;
    void Start()
    {
        for (int i = 0; i < numberOfObjects; i++)
        {
            float angle = i * Mathf.PI * 2 / numberOfObjects;
            float x = Mathf.Cos(angle) * radius;
            float y = Mathf.Sin(angle) * radius;
            Vector3 pos = transform.position + new Vector3(x, y, 10);
            float angleDegrees = -angle * Mathf.Rad2Deg;
            Quaternion rot = Quaternion.Euler(0, angleDegrees, 0);
            Instantiate(prefab, pos, rot);
        }
    }*/
}