using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private bool nextLevel = false;
    public int level;
    public float jumpForce = 6f;
    private bool canJumping = true;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    private void Update()
    {
        if(Input.GetKey(KeyCode.E) && nextLevel)
        {
            SceneManager.LoadScene(level);
        }
        if (Input.GetKey(KeyCode.Space) && canJumping)
        {
            rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
            canJumping = false;
        }
    }

    public void setNextLevel(bool value)
    {
        nextLevel = value;
    }

    public void PlayerDied()
    {
        Destroy(gameObject);
        Restart(); 
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Reset the jump state when the player lands on the ground
        if (collision.gameObject.CompareTag("Ground"))
        {
            canJumping = true;
        }
    }

    public void setJump(bool value)
    {
        canJumping = value;
    }
}
