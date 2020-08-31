using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NerfSpeed : MonoBehaviour
{
    // Start is called before the first frame update
    float speed = 4;
    Rigidbody rg;
    void Start()
    {
        rg = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rg.velocity.y > speed)
        {
            rg.velocity = Vector3.up * speed;
        }
        else if (rg.velocity.y < -speed)
        {
            rg.velocity = Vector3.up * -speed;
        }
    }
}
