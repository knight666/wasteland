using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeController : MonoBehaviour {

    public Inventory inventory;

    void Start()
    {
        inventory = GetComponentInChildren<Inventory>();
    }

    // Update is called once per frame
    void Update () {
		
	}

    private void OnMouseDown()
    {
        inventory.AddItem(new Item(Item.Type.Water), 15);
    }
}
