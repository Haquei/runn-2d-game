using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class jump : MonoBehaviour
{
	public bool grounded = true;
	public float jumpPower;

	void Update()
	{
		if (Input.GetKeyDown("space") || Input.GetMouseButtonDown(0) && grounded == true)
		{
			GetComponent<Rigidbody2D>().AddForce(transform.up * jumpPower);
			grounded = false;
		}

	}

}
