using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private Transform Pivot;
    float speed = 3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            transform.Rotate(Vector3.up * speed);
            //turn left
        }
        else if (Input.GetMouseButton(1))
        {
            //turn right --y
            transform.Rotate(-Vector3.up * speed);

        }
    }
}
