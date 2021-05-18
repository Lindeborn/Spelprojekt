using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;

    public float forwardForce = 500f;
    public float leftForce = 500f;
    public float rightForce = -500f;
    public float backwardForce = -500f;

    private bool canJump;
    public int jumpForce = 10;

    public SphereCollider col;
    public LayerMask groundLayers;

   // public float maxSpeed = 20f;//Replace with your max speed




    // Update is called once per frame

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        col = GetComponent<SphereCollider>();
    }
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(leftForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(rightForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(0, 0, backwardForce * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (canJump)
        {
            canJump = false;
            rb.AddForce(0, jumpForce, 0, ForceMode.Impulse);
           
           
        }

       /* if (rb.velocity.magnitude > maxSpeed)
        {
            rb.velocity = rb.velocity.normalized * maxSpeed;
        }
       */

    }

    void Update()
    {
        if (IsGrounded() && Input.GetKeyDown(KeyCode.Space))
        {
            canJump = true;
        }
    }

    

     private bool IsGrounded()
     {
         return Physics.CheckCapsule(col.bounds.center, new Vector3(col.bounds.center.x, col.bounds.min.y,
              col.bounds.center.z), col.radius * .9f, groundLayers);


     }


    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawSphere(col.bounds.center, col.radius * .9f);
    }

}
