using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sprite_Dragger : MonoBehaviour
{

    private bool havingTheSprite;
    private float startPositionX;
    private float startPositionY;

    private Vector2 originalPosition;
    private Vector2 newPosition;

    public GameObject[] sprites;
    private Vector2 offset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (havingTheSprite)
        {
            Vector2 mousePosition;
            mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

            this.transform.position = mousePosition + offset;
        }

        fireScreenRay();
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            havingTheSprite=true;
        }
    }

    private void OnMouseUp()
    {
        havingTheSprite = false;
        Vector2 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        Collider2D hitCollider = Physics2D.OverlapPoint(mousePosition);

        if (hitCollider != null)
        {
            Debug.Log("Hit collider: " + hitCollider.gameObject.name + " at position: " + hitCollider.transform.localPosition);
        }
        else
        {
            Debug.Log("No collider found at mouse position: " + mousePosition);
        }



        if (hitCollider != null && hitCollider.gameObject != this.gameObject)
        {
            newPosition = hitCollider.transform.localPosition;
            hitCollider.transform.localPosition = originalPosition;
            this.transform.localPosition = newPosition;

            Debug.Log("Swapped positions: " + this.gameObject.name + " with " + hitCollider.gameObject.name);
        }
        else
        {
            this.transform.localPosition = originalPosition;

            Debug.Log("Returned to original position: " + originalPosition);
        }
    }

    void fireScreenRay()
    {
        Ray cameraRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(cameraRay,out RaycastHit hitObject))
        {
            Debug.Log("the ray hit position is"+ hitObject.transform.localPosition);
        }
    }

}
