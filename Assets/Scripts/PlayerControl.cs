using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {
    public Rigidbody P1RB;
    public GameObject Person;
    public Animator ASM1;
    public float Player1Accel;
    public float rotateSpeed;
    private string Direction;
    public float smooth = 10f;
    public GameObject target;
    private Quaternion initRotation;
    private Quaternion targetRotation;
    private float x;

    private GameState GameState;
    void Start()
    {
        GameState = GameObject.Find("GameState").GetComponent<GameState>();

        Direction = "forward";
        initRotation = Person.transform.rotation;

        targetRotation = initRotation;
        target.transform.rotation = targetRotation;

    }

    void Update()
    {

            target.transform.rotation = targetRotation;
        Person.transform.rotation = Quaternion.Slerp(Person.transform.rotation, target.transform.rotation, smooth * Time.deltaTime);

            if ((Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.RightArrow)))
            {
                ASM1.SetBool("Walking", false);
            }
            if (!(Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.RightArrow)))
            {
                x = Input.GetAxis("Horizontal") * Time.deltaTime * 7.0f;
            }

            if ( !(Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.RightArrow)))
            {
                if (Input.GetKey(KeyCode.LeftShift)|| Input.GetKey(KeyCode.RightShift))
                {
                    ASM1.SetBool("Running", true);
                    x = x * 2;
                }
                else
                {
                    ASM1.SetBool("Running", false);
                }
                if (!(Input.GetKey(KeyCode.D) 
                || Input.GetKey(KeyCode.A)))
                { P1RB.transform.Translate(0, 0, x); }
            }

            if (!(Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.RightArrow)))
            {
                MovementControls();
            }

    }

    public void MovementControls()
    {


        if (Input.GetKeyDown(KeyCode.UpArrow) && GameState.canJump)// P1RB.velocity == Vector3.zero)
        {
            if (!(Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.RightArrow)))
            {
                P1RB.AddRelativeForce(transform.up * 6, ForceMode.Impulse);
                GameState.canJump = false;
                ASM1.SetTrigger("Jump");
            }
        }
        if (Input.GetKey(KeyCode.LeftArrow)|| Input.GetKey(KeyCode.RightArrow))
        {
            if (!(Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.RightArrow)))
            { 
                ASM1.SetBool("Walking", true);
            }
        }
        else
        {
            if (!(Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.RightArrow)))
            {
                ASM1.SetBool("Walking", false);
            }
        }      
        if (Direction == "forward" && Input.GetKey(KeyCode.LeftArrow))
        {
            if (!(Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.RightArrow)))
            {
                Direction = "backward";
                targetRotation = Quaternion.LookRotation(-target.transform.forward, Vector3.up);
            }
        }
        if (Direction == "backward" &&  Input.GetKey(KeyCode.RightArrow))
        {
            if (!(Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.RightArrow)))
            {
                Direction = "forward";
                targetRotation = Quaternion.LookRotation(-target.transform.forward, Vector3.up);
            }
        }
    }
}
