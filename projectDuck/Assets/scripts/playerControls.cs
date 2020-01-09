using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControls : MonoBehaviour
{
    public int jumpHight = 4;
    public int jumpDistance = 3;

    //is grounded variables
    public bool isGrounded;
    public LayerMask groundLayer;
    public float deadZone;

    //touch controls
    Vector2 startPos;
    Vector2 endPos;
    Vector2 direction;
    public bool stopJumping = true;

    //player components
    bool XAxisRotation;

    //pointer
    public bool hasStoppedJumping = false;
    public bool stomped = false;//send to swipe tutorial anim

    Animator jumpAnim;

    //swipe animation bools
    public bool jumpedRight = false;
    public bool jumpedLeft = false;

    private AudioSource soundToPlay;
    public AudioClip[] sounds;

    private void Start()
    {
        jumpAnim = GetComponentInChildren<Animator>();
        soundToPlay = gameObject.GetComponent<AudioSource>();
    }

    void Update()
    {
       
        jump();
     
    }

    void jump()
    {
        hasStoppedJumping = false;

        isGrounded = Physics2D.OverlapArea(new Vector2(transform.position.x - 0.5f, transform.position.y - 0.5f), new Vector2(transform.position.x + 0.5f, transform.position.y - 0.55f), groundLayer);//in the second paramiter y-0.61f can be changed depending on how tall the player object is

        if (Input.touchCount > 0)
        {
            Touch patima = Input.GetTouch(0);

            switch (patima.phase)
            {
                case TouchPhase.Began:
                    startPos = patima.position;
                    break;

                case TouchPhase.Moved:
                    break;

                case TouchPhase.Ended:
                    endPos = patima.position;
                    direction.x = startPos.x - endPos.x;
                    deadZone = endPos.x - startPos.x;
                    stopJumping = false;

                    break;
            }


        }
        /*from here 
        if (Input.GetButtonDown("Fire2")&& isGrounded)
        {
            hasStoppedJumping = true;//for bubbles script

            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(jumpHight, jumpDistance), ForceMode2D.Impulse);//jumps left

            stopJumping = true;

            gameObject.GetComponentInChildren<SpriteRenderer>().flipX = false;

            jumpAnim.Play("duckJumpAnimation");

            jumpedRight = true;

            soundToPlay.clip = sounds[0];
            soundToPlay.Play();


        }

        if (Input.GetButtonDown("Fire1") && isGrounded)
        {
            hasStoppedJumping = true;//for bubbles script

            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0 - jumpHight, jumpDistance), ForceMode2D.Impulse);//jumps right

            stopJumping = true;

            gameObject.GetComponentInChildren<SpriteRenderer>().flipX = true;

            jumpAnim.Play("duckJumpAnimation");

            jumpedLeft = true;

            soundToPlay.clip = sounds[0];
            soundToPlay.Play();

        }
        if (Input.GetButton("Fire3") && !isGrounded)
        {
            gameObject.GetComponent<Rigidbody2D>().gravityScale = 10;
            stomped = true;
        }
        else
        {
            gameObject.GetComponent<Rigidbody2D>().gravityScale = 3;
            stomped = false;
        }

        */

        if (25 < Mathf.Abs(deadZone))//if the touch has been moved more than 25 pixels
        {
            if (Input.touchCount == 0 && direction.x < 0 && isGrounded && !stopJumping)
            {
                hasStoppedJumping = true;//for bubbles script

                gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(jumpHight, jumpDistance), ForceMode2D.Impulse);//jumps left

               // deadZone = 0;

                stopJumping = true;

                gameObject.GetComponentInChildren<SpriteRenderer>().flipX = false;

                jumpAnim.Play("duckJumpAnimation");

                jumpedRight = true;

                soundToPlay.clip = sounds[0];
                soundToPlay.Play();


            }

            if (Input.touchCount == 0 && direction.x > 0 && isGrounded && !stopJumping)
            {
                hasStoppedJumping = true;//for bubbles script

                gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0 - jumpHight, jumpDistance), ForceMode2D.Impulse);//jumps right
                
               // deadZone = 0;

                stopJumping = true;

                gameObject.GetComponentInChildren<SpriteRenderer>().flipX = true;

                jumpAnim.Play("duckJumpAnimation");

                jumpedLeft = true;

                soundToPlay.clip = sounds[0];
                soundToPlay.Play();

            }

            if (Input.touchCount > 0 && !isGrounded)
            {
                gameObject.GetComponent<Rigidbody2D>().gravityScale = 10;
                stomped = true;
            }
            else
            {
                gameObject.GetComponent<Rigidbody2D>().gravityScale = 3;
                stomped = false;
            }
           
        }
     //   hasStoppedJumping = false;// here
    }

}
//                           hasStoppedJumping = true;//for bubbles scripT add on the end so it reseeeeeeeets 