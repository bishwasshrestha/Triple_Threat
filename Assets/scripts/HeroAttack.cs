﻿using System.Collections;
using UnityEngine;

public class HeroAttack : MonoBehaviour {

	private bool attacking = false;

	private float attackTimer = 0;
	private float attackCd = 0.3f;

	public Collider2D attackTrigger;

	private Animator anim;

	void Awake()
	{
		anim = gameObject.GetComponent<Animator>();
		attackTrigger.enabled = false;

	}

	void Update () 
	{
		if (Input.GetKeyDown ("s") && !attacking) {

			attacking = true;
			attackTimer = attackCd;

			attackTrigger.enabled = true;

		}

		if (attacking) {
			if (attackTimer > 0) {
				attackTimer -= Time.deltaTime;
			} else {
				attacking = false;
				attackTrigger.enabled = false;

			}
		}

		anim.SetBool ("Attacking", attacking);
	}
}
