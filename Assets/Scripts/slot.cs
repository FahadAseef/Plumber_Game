using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class slot : MonoBehaviour, IDropHandler
{
    //sprite_Dragger dragger;
    public void OnDrop(PointerEventData eventData)
    {
        if (transform.childCount == 0)
        {
            GameObject dropped = eventData.pointerDrag;
            sprite_Dragger draggableItem = dropped.GetComponent<sprite_Dragger>();
            draggableItem.parentAfterDrag = transform;
        }
        //gameObject.transform.position = dragger.originalPos;
    }
}
