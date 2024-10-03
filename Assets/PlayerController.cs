using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private Animator anim;
    private int pointGame;
    public Text pointText;

    public Vector3 gravity;
    public Vector3 jumpSpeed;

    bool isGrounded = false;

    Rigidbody rb;

    // Start is called before the first frame update
    private void Start()
    {
        pointGame = 0;
    }

    void Awake()
    {
        Physics.gravity = gravity;
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.velocity = jumpSpeed;
            isGrounded = false;
            pointGame++;
            pointText.text = pointGame.ToString();
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            anim.SetBool("roll",true);
            pointGame++;
            pointText.text = pointGame.ToString();
        }
        if (Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetBool("roll", false);
        }


    }

    private void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
    }
}
