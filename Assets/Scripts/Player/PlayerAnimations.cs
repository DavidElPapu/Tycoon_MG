using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    //Variables publicas
    public Player_Movement player_Movement;
    public GroundDetector groundDetector;

    //Variables privadas
    private float speed;
    private bool isGrounded;

    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        speed = 0;
        isGrounded = true;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckGrounded();
        CheckSpeed();
        SetParameters();
    }

    void SetParameters()
    {
        animator.SetFloat("Speed", speed);
        animator.SetBool("IsGrounded", isGrounded);
    }

    public void CheckSpeed()
    {
        speed = player_Movement.GetCurrentSpeed();
    }

    public void CheckGrounded()
    {
        isGrounded = groundDetector.GetIsGrounded();
    }
}
