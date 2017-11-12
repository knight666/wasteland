using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ItemSlot : MonoBehaviour {

    public Image icon;
    public Text amount;

    public void SetIcon(Sprite sprite)
    {
        icon.sprite = sprite;
        icon.enabled = true;
    }

    public void SetAmount(int value)
    {
        amount.text = value.ToString();
    }

}
