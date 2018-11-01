using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour {
	public float movespeed = 600f;
	private float movement = 0f;

	// Update is called once per frame
	void Update () {
		movement = Input.GetAxisRaw("Horizontal");
	}

	private void FixedUpdate()
	{
		transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.fixedDeltaTime * -movespeed);
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}
}
