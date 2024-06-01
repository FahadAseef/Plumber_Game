using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class slot : MonoBehaviour, IDropHandler
{
    //sprite_Dragger dragger;
    //[SerializeField] private win_Checker win_Checker;
    public void OnDrop(PointerEventData eventData)
    {
        if (transform.childCount == 0)
        {
            GameObject dropped = eventData.pointerDrag;
            sprite_Dragger draggableItem = dropped.GetComponent<sprite_Dragger>();
            draggableItem.parentAfterDrag = transform;
        }
        //gameObject.transform.position = dragger.originalPos;
        // Check if the game is won after every drop
        Debug.Log("Item dropped. Checking win condition.");
        //gameManager.Instance.CheckWinCondition();
        //win_Checker.wincheck();
    }
}
