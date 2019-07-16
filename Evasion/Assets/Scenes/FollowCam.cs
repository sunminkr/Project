using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    public Transform Target;
    public float dist = 15f;
    public float height = 5f;
    public float dampTrace = 20f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, Target.position - (Target.forward * dist) + (Vector3.up * height), Time.deltaTime * dampTrace);
        transform.LookAt(Target.position);
    }
}
