using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerarZombies : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Zombie;
    
     private Transform t;
    void Start()
    {
         t = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
         Instantiate(Zombie, t.position, Quaternion.identity);
         
    }
    
            
       
}
