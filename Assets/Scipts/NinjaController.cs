using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinjaController : MonoBehaviour
{
    private const int ANIMATION_QUIETO = 0;
    private const int ANIMATION_CORRER = 1;
    private const int ANIMATION_SALTAR= 2;
    private const int ANIMATION_ATACAR= 3;
    private Rigidbody2D rb;
    private Transform t;
    private Animator anim;
    private SpriteRenderer spri;
    public GameObject Kunai;
    // Start is called before the first frame update
    void Start()
    {
         rb = GetComponent<Rigidbody2D>();
        t = GetComponent<Transform>();
        t.position = new Vector3(-16, -4, 0);
        anim = GetComponent<Animator>();
        spri = GetComponent<SpriteRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(0, rb.velocity.y);
        anim.SetInteger("Estado", ANIMATION_QUIETO);
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = new Vector2(8, rb.velocity.y);
            anim.SetInteger("Estado", ANIMATION_CORRER);
            spri.flipX = false;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector2(-8, rb.velocity.y);
            anim.SetInteger("Estado", ANIMATION_CORRER);
            spri.flipX = true;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            anim.SetInteger("Estado", ANIMATION_SALTAR);
            rb.AddForce(new Vector2(0, 35), ForceMode2D.Impulse);
        }
         if (Input.GetKey(KeyCode.X))
        {
            
             anim.SetInteger("Estado", ANIMATION_ATACAR);
            Instantiate(Kunai, t.position, Quaternion.identity);
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Zombie")
       {
           anim.SetInteger("Morir", 1);
        }
    }
}
