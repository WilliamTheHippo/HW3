using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zip : MonoBehaviour
{
	public Collider2D trigger;

	TargetJoint2D tj;
	LineRenderer lr;

    void Start()
    {
        tj = GetComponent<TargetJoint2D>();
        lr = GetComponent<LineRenderer>();
    }

    void OnTriggerEnter2D(Collider2D c)
    {
        if(c.name == trigger.name)
        {
        	tj.enabled = false;
        	lr.enabled = false;
        }
    }

    void Update()
    {
        lr.SetPosition (0, transform.position);
        lr.SetPosition (1, new Vector2(tj.target.x, tj.target.y));
    }
}
