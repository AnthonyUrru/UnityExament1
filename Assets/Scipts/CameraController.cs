using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update
    private Transform tr;
    public GameObject player;
    private float x = 0f;
    void Start()
    {
        tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
         x = player.transform.position.x;
        tr.position = new Vector3(x,tr.position.y);
    }
}
