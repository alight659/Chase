using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public float speed;
	Vector3 vecDir;
	Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		vecDir = new Vector3(5,0,0).normalized;
	}

	void FixedUpdate()
	{
		rb.MovePosition(rb.position + transform.TransformDirection(vecDir) * speed * Time.deltaTime);
	}
}
