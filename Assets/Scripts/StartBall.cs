using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartBall : MonoBehaviour
{
	public Transform cameraTr;

	Rigidbody2D rb;
	Transform tr;

    void Start()
    {
    	tr = GetComponent<Transform>();
    	cameraTr.position = tr.position + new Vector3(0f,0f,-10f);
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.Space)) rb.bodyType = RigidbodyType2D.Dynamic;
    }
}
