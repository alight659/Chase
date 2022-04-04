using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tiles : MonoBehaviour {
	
	public GameObject[] tile;
	private List<GameObject> current = new List<GameObject>();
	public Transform player;
	private float z = 0;
	public float tileLen;
	public int qty;
	public int qtyMax;

	// Use this for initialization
	void Start () {
		for(var i = 0; i < qty; i++)
		{
			Spawn();
		}
	}
	
	// Update is called once per frame
	void Update () {
		if(player.position.z > -z - (qty*tileLen))
		{			
			if(current.Count > qtyMax)
			{
				Destroy(current[0]);
				current.RemoveAt(0);
			}
			else if (current.Count < qtyMax-1)
			{
				Spawn();
			}
			
		}
	}

	void Spawn()
	{
		GameObject gameObj = Instantiate(tile[Random.Range(0, tile.Length)], transform.forward * -z, transform.rotation);
		gameObj.transform.SetParent(transform);
		current.Add(gameObj);
		z += tileLen;
	}
}
