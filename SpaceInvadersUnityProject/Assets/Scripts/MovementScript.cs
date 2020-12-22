using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    [SerializeField] private float speed = 0.25f;
    [SerializeField] private float zRotation = 30;
    [SerializeField] private float yRotation = 30;
    [SerializeField] private float smooth = 3.0f;
    [SerializeField] private float border = 17f;


    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            var transform1 = transform;
            var position = transform1.position;

            if (!(position.x - speed < -border))
            {
                position.x -= speed;
            }

            transform1.position = position;

            Quaternion target = Quaternion.Euler(0, yRotation, zRotation);
            transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            var transform1 = transform;
            var position = transform1.position;

            if (!(position.x + speed > border))
            {
                position.x += speed;
            }

            transform1.position = position;

            Quaternion target = Quaternion.Euler(0, -yRotation, -zRotation);
            transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
        }
        else
        {
            Quaternion target = Quaternion.Euler(0, 0, 0);
            transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
        }
        /*
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
        }*/
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.Equals(""))
        {
            
        }
    }
}
