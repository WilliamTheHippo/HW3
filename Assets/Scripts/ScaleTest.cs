using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleTest : MonoBehaviour
{
	public float offset;
	public LineRenderer otherRenderer;

	LineRenderer lr;
	SpringJoint2D[] ropes;

    // Start is called before the first frame update
    void Start()
    {
    	lr = GetComponent<LineRenderer>();
        ropes = GetComponents<SpringJoint2D>();
        //Debug.Log(ropes[0].anchor.x);
    }

    // Update is called once per frame
    void Update()
    {
    	lr.SetPosition(0, ropes[0].attachedRigidbody.position +
        	Vector2.right * offset);
    	lr.SetPosition(1, ropes[0].connectedBody.position);
    	otherRenderer.SetPosition(0, ropes[1].attachedRigidbody.position +
        	Vector2.right * -1 * offset);
    	otherRenderer.SetPosition(1, ropes[1].connectedBody.position);
    }
}
