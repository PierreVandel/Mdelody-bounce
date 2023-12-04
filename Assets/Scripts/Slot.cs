using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class TSlot
{
    public int SlotIndex;
    public ESlotType SlotType;

    public override bool Equals(object obj)
    {
        TSlot other = obj as TSlot;

        if (other == null) return false;

        return this.SlotIndex == other.SlotIndex && this.SlotType == other.SlotType;
    }

    public static bool operator==(TSlot left, TSlot right)
    {
        return left.SlotIndex == right.SlotIndex && left.SlotType == right.SlotType;
    }

    public static bool operator!=(TSlot left, TSlot right)
    {
        return !(left == right);
    }
}
