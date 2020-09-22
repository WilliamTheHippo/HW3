using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
	public Transform cameraTransform;
	Transform target;

    void OnTriggerEnter2D(Collider2D c)
    {
        target = c.transform;
    }

    void Update()
    {
    	if(target != null)
    	{
    		cameraTransform.position = target.position + new Vector3(0f,0f,-10f);
    	}
    }
}
