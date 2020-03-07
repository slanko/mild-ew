using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controllerInputz : MonoBehaviour
{
    public float moveMult;
    public float rotateSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, Input.GetAxis("Vertical") * moveMult);
        transform.Rotate(0, Input.GetAxis("Horizontal") * rotateSpeed, 0);

        if(Input.GetButton("LB"))
        {
            transform.Rotate(0, -3, 0);
        }
        if (Input.GetButton("RB"))
        {
            transform.Rotate(0, 3, 0);
        }
    }
}
