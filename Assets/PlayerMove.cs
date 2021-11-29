using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    [SerializeField] private float LeftBorder;
    [SerializeField] private float RightBorder;
    [SerializeField] private Vector3 VelocityX;

    void Start()
    {
        transform.GetComponent<Rigidbody2D>().mass = 1;
    }

    // Update is called once per frame
    void Update()
    {
        // Keep object inside Border

        if (transform.position.x > RightBorder)
        {
            transform.position -= VelocityX * Time.deltaTime;
        }
        if (transform.position.x < LeftBorder)
        {
            transform.position += VelocityX * Time.deltaTime;
        }
        // Move with A,D
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= VelocityX * Time.deltaTime;
            return;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += VelocityX * Time.deltaTime;
            return;
        }

        
    }
}
