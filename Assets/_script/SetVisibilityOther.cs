using UnityEngine;

public class SetVisibilityOther : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public GameObject button;

    private void Start()
    {
        spriteRenderer = button.GetComponent<SpriteRenderer>();
        spriteRenderer.enabled = false;
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            spriteRenderer.enabled = true;
            other.GetComponent<Player>().setNextLevel(true);

        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (spriteRenderer != null)
            {
                spriteRenderer.enabled = false;
            }
            other.GetComponent<Player>().setNextLevel(false);

        }
    }
}
