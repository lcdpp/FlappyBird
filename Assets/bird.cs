using UnityEngine;
using System.Collections;

public class bird : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
		this.rigidbody2D.velocity = new Vector3(5, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButton(0))
		{
			Vector3 val = this.rigidbody2D.velocity;
			this.rigidbody2D.velocity = new Vector3(val.x, 5, val.z);
		}
	}
}
