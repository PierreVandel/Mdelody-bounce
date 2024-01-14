using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Droppable : MonoBehaviour, IDropHandler
{
    TSlot Slot;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnDrop(PointerEventData EventData) 
    {
        GameObject g = EventData.pointerDrag.transform.gameObject;

        if (g == null)
        {
            Debug.Log("No object dropped.");
            return;
        }

        Draggable d = g.GetComponent<Draggable>();

        if (d.Slot == Slot)
        {
            g.transform.position = EventData.position;
        }
    }

}
