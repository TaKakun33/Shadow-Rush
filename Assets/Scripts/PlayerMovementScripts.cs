using UnityEngine;

public class PlayerMovementScripts : MonoBehaviour
{
    public float speed = 3f;
    public Rigidbody2D rb;
    public Animator animator;
    public Vector2 movement;

    void Update()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");

        if (movement.magnitude > 0)
        {
            animator.SetBool("IsMoving",true);
            animator.SetFloat("Horizontal",movement.x);
            animator.SetFloat("Vertical",movement.y);
        } 
        else
        {
            animator.SetBool("IsMoving",false);
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }

}
