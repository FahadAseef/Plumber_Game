using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class win_Checker : MonoBehaviour
{ 
    [SerializeField] GameObject slot1;
    [SerializeField] GameObject L_TO_R;

    [SerializeField] GameObject slot2;
    [SerializeField] GameObject L_TO_R2;

    [SerializeField] GameObject slot3;
    [SerializeField] GameObject left_To_Bottom;

    [SerializeField] GameObject slot4;
    [SerializeField] GameObject top_To_Right;

    [SerializeField] GameObject win_UI;

    private void Update()
    {
        if (L_TO_R.transform.parent == slot1.transform)
        {
            if(L_TO_R2.transform.parent == slot2.transform)
            {
                if(left_To_Bottom.transform.parent == slot3.transform)
                {
                    if (top_To_Right.transform.parent == slot4.transform)
                    {
                        Debug.Log("you win");
                        win_UI.gameObject.SetActive(true);
                    }
                }
            }
        }
    }
}
