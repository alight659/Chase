using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
	
	public Text scoreDisp;
	float score;

	// Update is called once per frame
	void Update () {
		score += Time.deltaTime * 1000;
		scoreDisp.text = "Score: " + (int)score;
	}
	
	public void ResetScore()
	{
		score = 0;
	}
}
