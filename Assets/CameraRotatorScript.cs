using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotatorScript : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(Vector3.forward, Time.deltaTime * 30f);
	}
}
