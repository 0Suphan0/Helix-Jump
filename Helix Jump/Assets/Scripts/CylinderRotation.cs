using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderRotation : MonoBehaviour
{
    public float rotateSpeed;
    private float MoveX;

   
    void Update()
    {
        MoveX = Input.GetAxis("Mouse X");

        if (Input.GetMouseButton(0))
        {
            transform.Rotate(0f,-MoveX,0f*rotateSpeed*Time.deltaTime);
        }

    }



}
