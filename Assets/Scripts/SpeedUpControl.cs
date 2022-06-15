using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUpControl : MonoBehaviour
{
    public Collider2D ball;
    public float magnitude;

    public PUManager manager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)
        {
            ball.GetComponent<BallControl>().ActivatePUSpeedUp(magnitude);
            manager.RemovePowerUp(gameObject);
        }
    }
}
