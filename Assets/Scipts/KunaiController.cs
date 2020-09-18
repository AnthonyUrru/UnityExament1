using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KunaiController : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rb;
    public GameObject Zombie;
   
    private Transform t;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(10, rb.velocity.y);
        t = GetComponent<Transform>();
        Destroy(this.gameObject, 5);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Zombie")
        
       {
            Destroy(this.gameObject, 0);
           Instantiate(Zombie, t.position, Quaternion.identity);
         
        }
    }
}
