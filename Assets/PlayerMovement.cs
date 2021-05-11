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

   


    // Update is called once per frame

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        col = GetComponent<SphereCollider>();
    }
    void FixedUpdate()
    {
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        }

        if (Input.GetKey("d"))
        {
            rb.AddForce(500 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(rightForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, backwardForce * Time.deltaTime);
        }

        if (canJump)
        {
            canJump = false;
            rb.AddForce(0, jumpForce, 0, ForceMode.Impulse);
            Debug.Log(canJump);
           
        }
        
    }

    void Update()
    {
        if (IsGrounded() && Input.GetKeyUp(KeyCode.Space))
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
