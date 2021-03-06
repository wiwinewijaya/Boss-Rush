﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class Enemy : MonoBehaviour {
    public int damage;
    public float movementSpeed;

    public GameObject player;

    public void baseStart()
    {
        player = GameObject.Find("Player");
    }

    public void baseUpdate()
    {

    }

    public virtual void OnCollisionEnter2D(Collision2D hit)
    {
		if (hit.gameObject.CompareTag("Player") && !player.GetComponent<PlayerControls>().isPlayerInvincible())
        {
            player.GetComponent<PlayerControls>().doDamage(damage);
            Destroy(gameObject);
        }
    }   

    public virtual void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
