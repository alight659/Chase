using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnner : MonoBehaviour {

	public GameObject[] items;
	// Use this for initialization
	void Start () {
		GameObject gameObjkt = Instantiate(items[Random.Range(0, items.Length)], gameObject.transform.position, Quaternion.identity);
		gameObjkt.transform.SetParent(transform);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
