using UnityEngine;

public class Move_Player : MonoBehaviour
{
    private bool isJumping;
    private bool isGrounded;

    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask collisionLayers;


   /* public Animator animPlayer;*/

    public float jumpForce;
    public float moveSpeed;
    public Rigidbody2D rb;

    private Vector3 velocity = Vector3.zero;
    private float horizontalMouvement;

    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, collisionLayers);
        horizontalMouvement = Input.GetAxis("Horizontal") * moveSpeed * Time.fixedDeltaTime;

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            isJumping = true;
        }

        flip(rb.velocity.x);

        /* float characterVelocity = Mathf.Abs(rb.velocity.x);
         animPlayer.SetFloat("speed", characterVelocity);*/
    }

    void FixedUpdate()
    {

        movePlayer(horizontalMouvement);

    }

    void flip(float _velocityX)
    {
        if(_velocityX > 0.1f)
        {
            Character.instance.setScaleSkin(1f);
        } else if (_velocityX < -0.1f)
        {
            Character.instance.setScaleSkin(-1f);
        }
       
    }
    void movePlayer(float _horizontalMovement)
    {
        Vector3 targetVelocity = new Vector2(_horizontalMovement, rb.velocity.y);
        rb.velocity = Vector3.SmoothDamp(rb.velocity, targetVelocity, ref velocity, 0.05f);
        if (isJumping)
        {
            rb.AddForce(new Vector2(0f,jumpForce));
            isJumping = false;

        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(groundCheck.position, groundCheckRadius);

    }
}
