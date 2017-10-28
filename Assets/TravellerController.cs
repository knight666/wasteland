using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TravellerController : MonoBehaviour
{
	public int movementSpeed = 3;

	void Start()
	{
	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Mouse0))
		{
			var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			transform.position = ray.GetPoint(0.0f);
		}
	}
}
