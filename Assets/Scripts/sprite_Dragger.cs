using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class sprite_Dragger : MonoBehaviour,IBeginDragHandler, IDragHandler,IEndDragHandler
{

    [HideInInspector] public Transform parentAfterDrag;
    public Image image;
    public Image childImage;

    //public Vector2 originalPos;

    //private void Start()
    //{
    //originalPos = transform.position;
    //}

    //public Transform correctSlot;
    //win_Checker winChecker;
    //[SerializeField] private win_Checker win_Checker;
    //[SerializeField] private win_Checker win_Checker2;
    private win_Checker win_Checker;
    private win_Checker_2 win_Checker2;

    private void Update()
    {
        win_Checker = FindObjectOfType<win_Checker>();
        win_Checker2 = FindObjectOfType<win_Checker_2>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        parentAfterDrag = transform.parent;
        transform.SetParent(transform.root);
        transform.SetAsLastSibling();
        image.raycastTarget = false;
        childImage.raycastTarget = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        
        transform.position=Input.mousePosition;
        //image.raycastTarget = false;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        transform.SetParent(parentAfterDrag);
        image.raycastTarget = true;
        childImage.raycastTarget = true;

        // Check if the game is won after every drag end
        //gameManager.Instance.CheckWinCondition();
        //winChecker.wincheck();
        Scene activeScene = SceneManager.GetActiveScene();
        if (activeScene.buildIndex == 1)
            win_Checker.wincheck();
        if(activeScene.buildIndex == 2)
            win_Checker2.wincheck();


    }




    /*
    private bool isDragging;
    private Vector2 offset;
    private Vector2 original_Position;

    slot _slot;

    [SerializeField] Transform[] slotTransform;
    private bool isPlaced;
    [SerializeField] GameObject[] slots;
    private float dropDistance=0.5f;

    private void Start()
    {
        original_Position = transform.position;
    }
    private void Update()
    {
        if (isPlaced) return;
        if (!isDragging)
        {
            return;
        }

        var mousePosition = getMousePos();
        transform.position = mousePosition-offset; 

    }

    private void OnMouseDown()
    {
        isDragging = true;
        offset = getMousePos() - (Vector2)transform.position;
    }

    Vector2 getMousePos()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private void OnMouseUp()
    {
        //Vector2 mouseUpPosition=getMousePos();
        //if (Vector2.Distance(transform.position, mouseUpPosition) < 0.5)
        //{
        //    transform.position = mouseUpPosition;
        //    isDragging = false;
        //    isPlaced = true;
        //}
        //else
        //{
        //    isPlaced=false;
        //    transform.position = original_Position;
        //}
        //for(int i = 0; i < slots.Length; i++)
        //{
        //    float distance = Vector2.Distance(transform.position, slots[i].transform.position);
        //    if(distance > dropDistance)
        //    {
        //        transform.position = slots[i].transform.position;
        //        isDragging = false;
        //        isPlaced = true;
        //    }
        //    else
        //    {
        //        transform.position = original_Position;
        //        //isDragging = false;
        //    }
         
        //}

        transform.position = original_Position;
        isDragging = false;
        isPlaced = false;
    }
    */

}
