﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diamondscript : MonoBehaviour
{
    
    public SpriteRenderer rend;
    public Color newColor;
    public Transform other;
    [Range(-720, 720)]
    public float rotationSpeed; 
    

    // Use this for initialization
    void Start()
    {
        rend.color = newColor;
        rend.color = new Color(1f, 0.5f, 0.3f);
        //other.position = new Vector3(3, 2, other.position.z); 
        print(newColor);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(
                0f,
                0f,
                rotationSpeed * Time.deltaTime);
            transform.Translate(5f * Time.deltaTime, 0, 0, Space.Self);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(
                0f,
                0f,
                -rotationSpeed * Time.deltaTime);
            transform.Translate(5f * Time.deltaTime, 0, 0, Space.Self);
        }
    }
}
