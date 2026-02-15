using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float forwardForce = 2f;

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        rb.AddForce(Vector2.right * forwardForce);
    }
}
