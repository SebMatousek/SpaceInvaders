using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            var transform1 = transform;
            var position = transform1.position;
            position.x -= speed;
            transform1.position = position;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            var transform1 = transform;
            var position = transform1.position;
            position.x += speed;
            transform1.position = position;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            var transform1 = transform;
            var position = transform1.position;
            position.y += speed;
            transform1.position = position;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            var transform1 = transform;
            var position = transform1.position;
            position.y -= speed;
            transform1.position = position;
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.Equals(""))
        {
            
        }
    }
}
