using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    private SpriteRenderer sr;
    private Rigidbody2D rb;

    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    private void Update()
    {
        float moveX = Input.GetAxis("Horizontal");


        // Move the player horizontally
        rb.velocity = new Vector2(moveX * moveSpeed, rb.velocity.y);
        if (moveX > 0)
        {
            sr.flipX = false;
        }
        else if (moveX < 0)
        {
            sr.flipX = true;
        }
    }
}
