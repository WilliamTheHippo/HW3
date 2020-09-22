using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HangUp : MonoBehaviour
{
	public Sprite hungUp;
	public Rigidbody2D stop;
	public Rigidbody2D start;
	public LineRenderer line;

	SpriteRenderer sr;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    void OnTriggerEnter2D(Collider2D c)
    {
    	if(c.name == stop.name)
    	{
	    	sr.sprite = hungUp;
	    	stop.bodyType = RigidbodyType2D.Static;
	    	start.bodyType = RigidbodyType2D.Dynamic;
	    	line.enabled = true;
	    }
    }
}
