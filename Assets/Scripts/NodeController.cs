using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeController : MonoBehaviour {

    public Item[] Inventory = new Item[3];
    public InventoryView Renderer;

    void Start()
    {
        Renderer = GetComponentInChildren<InventoryView>();
    }

    // Update is called once per frame
    void Update () {
		
	}

    private void OnMouseDown()
    {
        Renderer.Render(Inventory);
    }
}
