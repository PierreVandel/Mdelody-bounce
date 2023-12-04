using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DraggableComponent : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    public Vector3 StartPosition;

    public TSlot Slot;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnBeginDrag(PointerEventData EventData)
    {
    }

    public void OnDrag(PointerEventData EventData)
    {
        transform.position = EventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
    }
}