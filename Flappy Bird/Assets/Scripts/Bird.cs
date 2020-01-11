using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    //Checks if the player is dead or not = false means alive
    private bool isDead = false;
    private Rigidbody2D rb2d;
    private Animator anim;
    public float upForce = 200f;

    // Start is called before the first frame update
    void Start()
    {
        //When the game starts if there is a rigid body 2d it will be attached to the bird
        rb2d = GetComponent<Rigidbody2D> ();

        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isDead == false)
        {
            //When the mouse is clicked
            if (Input.GetMouseButtonDown(0))
            {
                //Move the bird up, increase its y position
                rb2d.velocity = Vector2.zero;
                rb2d.AddForce(new Vector2(0, upForce));
                anim.SetTrigger ("Flap");
            }
        }
    }

    //When the bird collides with something, pipe, ground etc
    private void OnCollisionEnter2D(Collision2D collision)
    {
        isDead = true; // so the bird cant be clicked and move upward anymore
        anim.SetTrigger ("Die");
    }
}
