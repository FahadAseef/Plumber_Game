using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sprite_Dragger : MonoBehaviour
{

    private bool havingTheSprite;

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

            this.gameObject.transform.localPosition = new Vector2(mousePosition.x, mousePosition.y);
        }
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButton(0))
        {
            //Vector2 mousePosition;
            //mousePosition = Input.mousePosition;
            //mousePosition=Camera.main.ScreenToWorldPoint(mousePosition);

            havingTheSprite = true;
        }
    }

    private void OnMouseUp()
    {
        havingTheSprite = false;
    }

}
