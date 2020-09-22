using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncy1 : MonoBehaviour
{
	public PhysicsMaterial2D material;

	public Collider2D makeBouncy;
    public Collider2D stop;

	Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void OnTriggerEnter2D(Collider2D c)
    {
        if(c == makeBouncy) rb.sharedMaterial = material;
        if(c == stop) rb.bodyType = RigidbodyType2D.Static;
    }
}
