using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public string itemName;
    public int itemID;
    public string itemDes;
    public ItemType itemType;
    public Texture2D itemIcon;


    public enum ItemType
    {
        Key,
        Memo,
        PuzzlePiece
    }
}
