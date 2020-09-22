using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roll : MonoBehaviour
{
	public float force;
	public Collider2D trigger;

	Rigidbody2D rb;
	bool triggered; 

    void Start()
    {
    	rb = GetComponent<Rigidbody2D>();
        triggered = false;
    }

    void OnTriggerEnter2D(Collider2D c)
    {
    	if(c.name == trigger.name)
    	{
    		if(!triggered)
            {
                rb.AddForce(new Vector2(-1f,0f) * force);
            }
    		triggered = true;
    	}
    }
}
