using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    bool isDead = false;
    Rigidbody2D rb2d;
    Animator anim;
    public float upForce = 200f;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isDead == false)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb2d.velocity = Vector2.zero;
                rb2d.AddForce(new Vector2(0, upForce));
                anim.SetTrigger("Steer");
            }
        }
        else if (isDead == true)
        {
            anim.SetTrigger("Crash");
        }
    }

    private void OnCollisionEnter2D()
    {
        isDead = true;   
    }
}
