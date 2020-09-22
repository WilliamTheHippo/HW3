using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushDown : MonoBehaviour
{
	public float force;

	Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void OnTriggerEnter2D(Collider2D c)
    {
        if(c.name == "Basket") rb.AddForce(new Vector2(0f,-1f) * force, ForceMode2D.Impulse);
    }
}
