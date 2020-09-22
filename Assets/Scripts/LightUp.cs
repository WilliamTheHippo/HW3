using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightUp : MonoBehaviour
{
	public Collider2D trigger;
	public Rigidbody2D dropBody;
	public Sprite litUp;

	SpriteRenderer sr;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    void OnTriggerEnter2D(Collider2D c)
    {
        sr.sprite = litUp;
        dropBody.bodyType = RigidbodyType2D.Dynamic;
    }
}
