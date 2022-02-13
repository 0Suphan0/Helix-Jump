using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEditor.Experimental;
using UnityEngine;
using UnityEngine.UI;

public class BallJump : MonoBehaviour
{
    private Rigidbody ballRigidbody;
    public float jumpForce;
    public GameObject PaintSplash;
    public Text ScoreText;
    int score = 0;
    private bool canNotDoubleJump;
    void Start()
    {

        ballRigidbody = GetComponent<Rigidbody>();
        

    }

    // Update is called once per frame
    void FixedUpdate()
    {
       
    }
    
   
    void OnCollisionEnter(Collision collision)
    {
        canNotDoubleJump = false;

        if (canNotDoubleJump==false)
        {
            canNotDoubleJump = true;
            ballRigidbody.AddForce(Vector3.up * jumpForce);
            GameObject splash = Instantiate(PaintSplash, transform.position, transform.rotation);

            splash.transform.SetParent(collision.gameObject.transform);


            if (collision.gameObject.tag == "Unsafe")
            {
                Debug.Log("Game Over!");
            }
            else if (collision.gameObject.tag == "Safe")
            {
                Debug.Log("Devam");
            }
            else
            {
                Debug.Log("Kazandýnýz..");
            }
        }
        
          
      

    }

    void CounterMethod()
    {

        
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("Point"))
        {
            score++;
            ScoreText.text = score.ToString();
            Convert.ToInt32(score);
        }

    }

}
