using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere78 : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.mass = 1000;
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(50f, 0, 50f);
    }

    void OnCollisionEnter(Collision col){
        if(col.gameObject.tag == "bad"){
            Destroy(gameObject);
        }
    }

    void OnMouseDown()
    {
        Destroy(gameObject);
    }
}
