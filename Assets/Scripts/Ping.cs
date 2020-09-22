using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ping : MonoBehaviour
{
    public Collider2D startingThingy;

	AudioSource ping;
	bool pinged;

    void Start()
    {
        ping = GetComponent<AudioSource>();
        pinged = false;
    }

    void OnTriggerEnter2D(Collider2D activator)
    {
    	if(activator != startingThingy && !pinged)
    	{
    		ping.Play();
    		pinged = true;
    	}
    }
}
