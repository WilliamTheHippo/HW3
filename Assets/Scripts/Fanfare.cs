using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fanfare : MonoBehaviour
{
	public Rigidbody2D stop;
	public SpriteRenderer spriteRenderer;
	public AudioSource music;

	AudioSource fanfare;

    void Start()
    {
        fanfare = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D()
    {
        stop.bodyType = RigidbodyType2D.Static;
        spriteRenderer.enabled = false;
        music.Stop();
        fanfare.Play();
    }
}
