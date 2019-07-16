using UnityEngine;
using System.Collections;

public class FPSMove : MonoBehaviour
{

    public Animator animator;

    public float speed = 6;
    public float jump = 15;
    public float gravity = 100;

    public float h;
    public float v;

    Vector3 move = Vector3.zero;


    public bool groundedComputed = false;
    public float groundY;
    CharacterController con;

    // Use this for initialization
    void Start()
    {

        con = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
        //Debug.Log ("FPSMove start");

    }

    // Update is called once per frame
    void Update()
    {

        //if( con.isGrounded) //temporarily disabled
        {

            move = new Vector3(Input.GetAxis("Vertical"), 0, -Input.GetAxis("Horizontal")); //좌우 부분이 키보트에 맞게 움직이도록 '-'를 추가함
            move *= speed;
            if (Input.GetButton("Jump"))
            {
                move.y = jump;
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                animator.Play("Jumpoo", -1, 0);
            }
            h = Input.GetAxis("Horizontal");
            v = Input.GetAxis("Vertical");

            animator.SetFloat("h", h);
            animator.SetFloat("v", v);

            //Debug.Log ("Grounded...");

            //Vector3 position = transform.position;
            //groundY = position.y;
            //groundedComputed = true;

        }

        move.y -= gravity * Time.deltaTime;
        con.Move(move * Time.deltaTime);

        //print for debugging
        //Debug.Log ("move=" + move.x + "," + move.y + "," + move.z);
        Vector3 newPosition = transform.position;
        //Debug.Log ("pos=" + newPosition.x + "," + newPosition.y + "," +	newPosition.z);

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

    }    
}
