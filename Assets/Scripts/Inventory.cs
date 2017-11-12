using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Inventory : MonoBehaviour
{
    public Image[] itemImages = new Image[numItemSlots];
    public Item[] items = new Item[numItemSlots];

    public const int numItemSlots = 3;

    public Sprite GetItemSprite(Item item)
    {
        switch (item.type)
        {

        case Item.Type.Food:
            return Resources.Load<Sprite>("Sprites/food");

        case Item.Type.Gasoline:
            return Resources.Load<Sprite>("Sprites/gasoline");

        case Item.Type.Water:
            return Resources.Load<Sprite>("Sprites/water");

        default:
            return null;

        }
    }

    public void AddItem(Item itemToAdd, int ItemCount)
    {
        //look through all items slots to find one that is empty --> then populate it with desired amount of items
        for (int i = 0; i < items.Length; i++)
        {
            if (items[i] == null)
            {
                items[i] = itemToAdd;

                itemImages[i].sprite = this.GetItemSprite(itemToAdd);
                itemImages[i].enabled = true;
                return;
            }
        }
    }

    public void RemoveItem(Item itemToRemove, int amountToRemove)
    {
        //look through all items until we finde the desired one that we want to remove
        for (int i = 0; i < items.Length; i++)
        {
            if (items[i] == itemToRemove)
            {
                items[i] = null;
                itemImages[i].sprite = null;
                itemImages[i].enabled = false;
                return;
            }
        }
    }
}
