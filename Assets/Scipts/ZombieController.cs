using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieController : MonoBehaviour
{

    private Rigidbody2D rb;
    private SpriteRenderer spri;
    private Transform t;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spri = GetComponent<SpriteRenderer>();
        t = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(-5, rb.velocity.y);
    }
     private void OnCollisionEnter2D(Collision2D zombie)
       {
           if (zombie.gameObject.tag == "Ninja"||zombie.gameObject.tag=="Kunai")
           {
               Destroy(this.gameObject, 0);
              //anim.SetInteger("Morir", 1);
            //Debug.Log("Se colisiono con " + zombie.gameObject.name);
            
        }
}
}
