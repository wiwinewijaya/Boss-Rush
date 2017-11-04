﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour {

	private Transform player;
	private Rigidbody2D rb2d;
	public float moveSpeed = 7;
	public float jumpStrength = 7;
	// Use this for initialization
	void Start () {
		player = GetComponent<Transform> ();
		rb2d = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.D))
		{
			player.transform.position += new Vector3 (0.1f, 0, 0);
		}

		if (Input.GetKey (KeyCode.A))
		{
			player.transform.position += new Vector3 (-0.1f, 0, 0);
		}

		if (Input.GetKeyDown (KeyCode.Space))
		{
			rb2d.AddForce (new Vector3 (0, 1, 0) * jumpStrength);
		}
	}
}