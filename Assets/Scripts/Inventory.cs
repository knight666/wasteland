using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Inventory : MonoBehaviour
{
    public ItemSlot[] itemSlots = new ItemSlot[numItemSlots];
    public Item[] items = new Item[numItemSlots];

    public const int numItemSlots = 3;

    public Inventory()
    {
    }

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
            if (items[i] != null &&
                items[i].type == itemToAdd.type)
            {
                items[i].amount += ItemCount;
                itemSlots[i].SetAmount(items[i].amount);

                return;
            }

            if (items[i] == null)
            {
                
                items[i] = itemToAdd;
                items[i].amount = ItemCount;

                itemSlots[i].SetIcon(GetItemSprite(itemToAdd));
                itemSlots[i].SetAmount(items[i].amount);

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

                return;
            }
        }
    }
}
