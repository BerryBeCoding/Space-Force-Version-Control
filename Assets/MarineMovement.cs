using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class MarineMovement : MonoBehaviour

{
    public CharacterController2Dv2 controller;
    float horizontalMove = 0f;
    public float runSpeed = 40f;
    bool jump = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        
            if (Input.GetButtonDown("Jump"))
        { 
                jump = true;
        }
    


        
    }
    void FixedUpdate()
    {
        //move the character
        controller.Move(horizontalMove*Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}
