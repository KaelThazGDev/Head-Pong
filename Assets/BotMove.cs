using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotMove : MonoBehaviour
{
    [SerializeField] private float LeftBorder;
    [SerializeField] private float RightBorder;
    [SerializeField] private Vector3 VelocityX;
    private bool movingLeft = true;
    private bool botPatrolStatus = true;

    private int touchPlayerTimes = 0;
    private int startCalculation = 1; 
    public void Start()
    {
    }

    void Update()
    {

        if (botPatrolStatus)
        {
            Patrol();
        }

        // Check if Player touch the ball. then calculate the landing point of the ball
        GameObject ball = GameObject.Find("Ball");
        touchPlayerTimes = ball.transform.GetComponent<BallMove>().touchPlayer;
        if (startCalculation == touchPlayerTimes)
        {
            Debug.Log("Player touch the ball");
            botPatrolStatus = false;
            startCalculation ++;
        }

    }

    // Moving when Player haven't touch the ball
    private void Patrol()
    {
        if (transform.position.x > RightBorder)
        {
            transform.position -= VelocityX * Time.deltaTime;
            movingLeft = true;
        }
        if (transform.position.x < LeftBorder)
        {
            transform.position += VelocityX * Time.deltaTime;
            movingLeft = false;
        }
        if (movingLeft)
        {
            transform.position -= VelocityX * Time.deltaTime;
        }
        else
        {
            transform.position += VelocityX * Time.deltaTime;
        }
    }

    IEnumerator BallLandingPointCaculation()
    {
        if (!botPatrolStatus)
        {

        }
        yield return null;
    }
}
