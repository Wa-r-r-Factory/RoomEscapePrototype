using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{

    public enum ItemType
    {
        Key,
        Puzzle
    }

    public ItemType itemType;
    public int amount;

    public Sprite GetSprite()
	{
		switch (itemType)
		{
            default:
            case ItemType.Key:      return ItemAssets.Instance.key;
            case ItemType.Puzzle:   return ItemAssets.Instance.puzzle;
		}
	}
}
