using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Speed = 0;
    public Rigidbody rb;

    float horizontalInput;
    public float LeftRightSpeed = 2;
    


    private void FixedUpdate()
    {
      //Vector3 forwardMove = transform.forward * Speed * Time.fixedDeltaTime;
     //Vector3 horinzontalMove = transform.right * horizontalInput * Speed * Time.fixedDeltaTime * horizontalMultiplier;
      //rb.MovePosition(rb.position + forwardMove);  

    }
    

    private void Update () {

         if(Input.GetKey(KeyCode.LeftArrow))
        {
            if(this.gameObject.transform.position.x > -3)
            {
                transform.Translate(Vector3.left * Time.deltaTime * LeftRightSpeed);
            }
        }

         if(Input.GetKey(KeyCode.RightArrow))
        {
            if(this.gameObject.transform.position.x < 3)
            {
            transform.Translate(Vector3.left * Time.deltaTime * LeftRightSpeed * -1);
            }
        }//player.transform.rotation=camera.main.transform.rotation;
    }
        
}
