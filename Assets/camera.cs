using UnityEngine;
using System.Collections;

public class camera : MonoBehaviour {

	private GameObject bird;
	private Transform birdTransform;

	// Use this for initialization
	void Start () {
		bird = GameObject.FindGameObjectWithTag("Player");
		birdTransform = bird.transform;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 birdPos = birdTransform.position;
		Vector3 cameraPos = this.transform.position;
		this.transform.position = new Vector3(birdPos.x, birdPos.y, cameraPos.z);
	}
}
