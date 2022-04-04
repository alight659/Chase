using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public float speed;
	Vector3 vecDir;
	Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Locked;
	}
	
	// Update is called once per frame
	void Update () {
		vecDir = new Vector3(5 * Time.deltaTime * 10f, 0, -Input.GetAxis("Mouse X") * speed).normalized;
		this.transform.rotation = Quaternion.Euler(0,90,0); //to ensure the car does not lilt 
	}

	void FixedUpdate()
	{
		rb.MovePosition(rb.position + transform.TransformDirection(vecDir) * speed * Time.deltaTime);
	}
}
