using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnHideBarier : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private Collider2D collider2D;
    public GameObject barrier;

    private void Awake()
    {
        spriteRenderer = barrier.GetComponent<SpriteRenderer>();
        collider2D = barrier.GetComponent<Collider2D>();
        spriteRenderer.enabled = false;
        collider2D.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            spriteRenderer.enabled = true;
            collider2D.enabled = true;

        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            spriteRenderer.enabled = false;
            collider2D.enabled = false;
        }
    }
}
