using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PllayerMovement : MonoBehaviour
{
    [SerializeField]private float speed;
    private Rigidbody body;

    //Loads one time when the game starts
    private void Awake()
    {
        body = GetComponent<Rigidbody>();
    }

     private void Update()
    {
        //Right and left movement
        body.velocity = new Vector3(Input.GetAxis("Horizontal") * speed,body.velocity.y);


        //Checks if space is pressed
        if (Input.GetKey(KeyCode.Space))
            body.velocity = new Vector3(body.velocity.x, speed);
    }
}
