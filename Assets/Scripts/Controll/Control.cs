using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Control : MonoBehaviour
{
    public float horizontalSpeed;
    float speedX;
    public float verticalImpulse;
    Rigidbody2D rd;
    bool Grounded;
    public Animator anim;
    


    // Start is called before the first frame update
    void Start()
    {
        rd = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

    }

    //public void LeftButtonDown()
    //{
    //    GetComponent<SpriteRenderer>().flipX = true;
    //    anim.SetBool("isRunning", true);
    //    anim.SetBool("isJamp", false);
    //    speedX = -horizontalSpeed;
    //}

    //public void RightButtonDown()
    //{
    //    GetComponent<SpriteRenderer>().flipX = false;
    //    anim.SetBool("isRunning", true);
    //    anim.SetBool("isJamp", false);
    //    speedX = horizontalSpeed;
    //}

    //public void Stop()
    //{
    //    anim.SetBool("isRunning", false);
    //    anim.SetBool("isJamp", false);
    //    speedX = 0;

    //}

    //public void OnClickJamp()
    //{
    //    anim.SetBool("isRunning", false);
        
    //    if(gameObject.tag == "Ground")
    //    {
    //        anim.SetBool("isJamp", false);
    //    }
    //    else
    //    {
    //        anim.SetBool("isJamp", true);
    //    }

    //    if (Grounded)
    //    {
    //        rd.AddForce(new Vector2(0, verticalImpulse), ForceMode2D.Impulse);
    //    }
    //}


    // Update is called once per frame
    void Update()
    {
        transform.Translate(speedX, 0, 0);
        if (Input.GetKey(KeyCode.D))
        {

            GetComponent<SpriteRenderer>().flipX = false;
            anim.SetBool("isRunning", true);
            //anim.SetBool("isJamp", false);
            speedX = horizontalSpeed;
        }
        else
        {
            speedX = 0;
            anim.SetBool("isRunning", false);
            anim.SetBool("isJamp", false);
        }

        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<SpriteRenderer>().flipX = true;
            anim.SetBool("isRunning", true);
           // anim.SetBool("isJamp", false);
            speedX = -horizontalSpeed;
        }



        if (Input.GetKeyDown(KeyCode.W) )
        {
            anim.SetBool("isRunning", false);

            if (gameObject.tag == "Ground")
            {
                anim.SetBool("isJamp", false);
            }
            else
            {
                anim.SetBool("isJamp", true);
                anim.SetBool("isRunning", false);
            }
            
            
            
            if(Grounded)
            rd.AddForce(new Vector2(0, verticalImpulse), ForceMode2D.Impulse);

        }
       

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            Grounded = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            Grounded = false;
        }
    }

    
}
