using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb2d;
    SurfaceEffector2D surfaceEffector2D;
    [SerializeField] float torqueAmount = 1f;
    [SerializeField] float boostSpeed = 27f;
    [SerializeField] float baseSpeed = 15f;
    bool canMove = true;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {   
        if (canMove){
            rotatePlayer();
            respondToBoost();
        }
    }

    public void disableControls(){
        canMove = false;
    }

    private void respondToBoost()
    {
        //if we push up then speed up, otherwise stay at normal speed
        //must access surfaceEfeector2D and boost its speed
        if (Input.GetKey(KeyCode.W)){
            surfaceEffector2D.speed = boostSpeed;
        } 
        else{
            surfaceEffector2D.speed = baseSpeed;
        }

        
    }

    void rotatePlayer()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb2d.AddTorque(torqueAmount);
        }

        else if (Input.GetKey(KeyCode.D))
        {
            rb2d.AddTorque(-torqueAmount);
        }
    }
}
