using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public Rigidbody catRB;
    Vector3 myInput;

    public int jumpforce;

    public bool onFloor;
    public bool canjump = true;

    public bool jumping = false;

   
   
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Cursor.lockState = CursorLockMode.Locked;
        //Cursor.visible = true;

        float horizontal = Input.GetAxis("Horizontal");//a/d or left/right
        float vertical = Input.GetAxis("Vertical");//w/s or up/down

        int layerMask = 1 << 8;

        myInput = vertical * transform.forward;
        myInput += horizontal * transform.right;

        myInput.y = catRB.velocity.y/6;

        Ray jumpRay = new Ray(transform.position, Vector3.down);
        Ray pushRay = Camera.main.ScreenPointToRay(Input.mousePosition);

        //STEP 2: declare the maximum distance of the raycast
        float jumpRayDist = 0.6f;
        float pushRayDist = 100000f;

        //STEP 3: (recommended) visualize the raycast
        Debug.DrawRay(jumpRay.origin, jumpRay.direction * jumpRayDist, Color.red);
        Debug.DrawRay(pushRay.origin, pushRay.direction * pushRayDist, Color.cyan);

        RaycastHit pushHit;

        //STEP 4： actually shoot the raycast now

        

        if (Physics.Raycast(pushRay, out pushHit, pushRayDist,layerMask))
        {
            Vector3 pushTransform = pushHit.transform.position;
            Vector3 catTransform = catRB.transform.position;

            Debug.Log("push");
            if (pushHit.distance <= 2f)
            {
           
                if (Input.GetMouseButton(0))
                {
                    if(Mathf.Abs(pushTransform.z - catTransform.z) > 1f)
                    {
                        pushHit.rigidbody.AddForce(new Vector3(0, 0, (pushTransform.z - catTransform.z)) * 200f);
                    }

                    if(Mathf.Abs(pushTransform.z - catTransform.z) <= 1f)
                    {
                        if(pushTransform.x > catTransform.x)
                        {
                            pushHit.rigidbody.AddForce(Vector3.right * 150f);
                        }
                        else
                        {
                            pushHit.rigidbody.AddForce(Vector3.left * 150f);
                        }


                    }
                  
                     
                }
            }
        }


            if (Physics.Raycast(jumpRay, jumpRayDist))
        {
            //Debug.Log("Raycast returns true!");
            onFloor = true;
           
        }
        else
        {
            onFloor = false;
            canjump = false;
        }

        if (onFloor)
        {
            canjump = true;
        }

        if (canjump == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                jumping = true;
                Debug.Log("jumping");

                
            }
            else
                jumping = false;

        }

        if(canjump == false)
        {
            jumping = false;
        }
    }
    private void FixedUpdate()
    {
        if (jumping)
        {
            Debug.Log("addforce");
            catRB.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);
            
        }

        catRB.velocity = myInput * 6f;
        



    }
    



   

   
}
