using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
[System.Serializable]
public class Anim
{
    public AnimationClip idle;
    public AnimationClip idle_Aim;
    public AnimationClip idle_Firing;
    public AnimationClip idle_Reload;
    public AnimationClip jump;
    public AnimationClip left_Fire;
    public AnimationClip right_Fire;
    public AnimationClip aim_Running;
    public AnimationClip run_firing;
    public AnimationClip run_Backward;
    public AnimationClip run_Forward;
    public AnimationClip stand_Aim_Down;
    public AnimationClip stand_Aim_Up;
    public AnimationClip standing2;
    public AnimationClip strafe_Left;
    public AnimationClip strafe_Right;
    public AnimationClip walk;
    public AnimationClip walk_Aiming;
    public AnimationClip walk_Firing;
}
*/
public class MovePlayer : MonoBehaviour
{
    public float moveSpeed = (float) 0.5;
 
   // public Anim anim;
   // public Animation _animation;

    // Start is called before the first frame update
    void Start()
    {
     //   _animation = GetComponentInChildren<Animation>();
     //   _animation.clip = anim.idle;
     //   _animation.Play();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(h, 0, v) * moveSpeed * Time.deltaTime, Space.World);
        transform.Rotate(new Vector3(0, Input.GetAxis("Mouse X"), 0));

        /*
        if (v >= 0.1f) _animation.CrossFade(anim.run_Forward.name, 0.3f) ;
        else if (v <= -0.1f) _animation.CrossFade(anim.run_Backward.name, 0.3f) ;
        else if (h >= 0.1f) _animation.CrossFade(anim.strafe_Left.name, 0.3f) ;
        else if (h <= -0.1f) _animation.CrossFade(anim.strafe_Right.name, 0.3f) ;
        else _animation.CrossFade(anim.idle.name, 0.3f);
        */

    }
}
