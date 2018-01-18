
using UnityEngine;
using System;
using System.Collections;


[System.Serializable]
public class Item
{
    public Item(Type type)
    {
        this.type = type;
    }

    public Sprite sprite;

    public enum Type
    {
        Water,
        Food,
        Gasoline
    };
    public Type type;

    public int amount = 0;
}