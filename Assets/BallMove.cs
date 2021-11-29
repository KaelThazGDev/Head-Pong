using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    public int touchPlayer = 0;
    void Start()
    {
    }

    void Update()
    {
        float spinAngle = transform.GetComponent<Rigidbody2D>().angularVelocity;
    
        transform.eulerAngles += new Vector3(0,0,spinAngle*100);


    }
 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Ground")
        {
            if (transform.position.x >0)
            {
                Debug.Log("Player win");
            }
            else
            {
                Debug.Log("Bot win");
            }
        }
        if (collision.gameObject.name == "Player")
        {
            touchPlayer++;
        }
    }

}
