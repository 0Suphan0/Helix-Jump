using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControler : MonoBehaviour
{
    public Transform ball;
    private Vector3 offset;
    public float smoothSpeed;

    void Start()
    {
        offset = transform.position - ball.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = Vector3.Lerp(transform.position, offset + ball.position, smoothSpeed);

        transform.position = newPosition;

    }
}
