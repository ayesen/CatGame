using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    float verticalAngle = 0f;

   

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");//horizontal mouse velocity
        float mouseY = Input.GetAxis("Mouse Y");//vertival mouse velocity

        transform.parent.Rotate(/*-mouseY * 10f*/0, mouseX * 5f, 0f);//rotate the parent of camera which is the cube

        //float verticalAngle = transform.localEulerAngles.x;
        verticalAngle -= mouseY * 1f;
        verticalAngle = Mathf.Clamp(verticalAngle, -80f, 80f);

        //X = pitch, Y = Yaw, Z = Roll..set z = to unroll the camera
        transform.localEulerAngles = new Vector3(verticalAngle, transform.localEulerAngles.y, 0f);
    }

   
}
