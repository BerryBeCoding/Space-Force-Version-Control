using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class CameraMove : MonoBehaviour

{
    public Transform CamMove;

    // Start is called before the first frame update
    void Start()
    {
        CamMove = GameObject.FindGameObjectWithTag("Player").transform;     

        
    }

    // Update is called once per frame

    //We store camera position in temp variable
    void LateUpdate()
    {
        Vector3 temp = transform.position;

        //we set the camera's position x to be equal to the player's position x
        temp.x = CamMove.position.x;





        
    }
}
