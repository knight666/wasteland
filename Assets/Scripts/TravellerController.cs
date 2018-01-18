using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TravellerController : MonoBehaviour
{
	public int movementSpeed = 3;

	void Start()
	{
        Inventory PlayerInventory = GetComponentInChildren<Inventory>();
        if (PlayerInventory != null)
        {
            PlayerInventory.AddItem(new Item(Item.Type.Water), 15);
           // PlayerInventory.AddItem(new Item(Item.Type.Water), 13);
           // PlayerInventory.AddItem(new Item(Item.Type.Water), 62);
        }
	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Mouse0))
		{
			var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

			RaycastHit hit;
			if (Physics.Raycast(ray, out hit))
			{
				if (hit.transform.name.StartsWith("Node"))
				{
					transform.position = hit.transform.position;
				}
            }
		}
	}
}
