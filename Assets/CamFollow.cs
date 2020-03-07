using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public GameObject followTarget;
    public float lerpTime;
    public float camLerpTime;
    public float rotateSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, followTarget.transform.position, lerpTime);
        transform.rotation = Quaternion.Slerp(transform.rotation, followTarget.transform.rotation, camLerpTime);
    }


}
