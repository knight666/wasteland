
using UnityEngine;


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