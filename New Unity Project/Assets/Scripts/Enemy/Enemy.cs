using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    [SerializeField]
    private Vector2 speed;
    [SerializeField]
    private float sinOffset;

    private Rigidbody2D rb;
    private Vector2 position;

    private float sinRotation, defaultY;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        defaultY = rb.position.y;
    }

    void Update()
    {
        position = rb.position;
        Move();
    }

    public void Move()
    {
        Vector2 add = position;
        add.x += speed.x;
        add.y = defaultY + (sinOffset * Mathf.Sin(sinRotation * Mathf.PI / 180));

        rb.position = add;

        sinRotation += speed.y;
        sinRotation %= 360;
    }

    public void CheckPosition(float x, float y)
    {

    }
    
    // Set to private after CheckPosition works
    public void Die()
    {
        Debug.Log("Die");
        Destroy(gameObject);
    }
}
