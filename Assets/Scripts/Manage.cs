using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manage : MonoBehaviour {

	public GameObject gameOverMnu;

	// Use this for initialization
	void Start () {
		gameOverMnu.SetActive(false);
		Time.timeScale = 1f;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
