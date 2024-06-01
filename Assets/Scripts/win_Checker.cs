using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class win_Checker : MonoBehaviour
{   
    [SerializeField] GameObject slot1;
    [SerializeField] GameObject L_TO_R;

    [SerializeField] GameObject slot2;
    [SerializeField] GameObject L_To_B;

    [SerializeField] GameObject slot5;
    [SerializeField] GameObject T_TO_R;

    [SerializeField] GameObject slot6;
    [SerializeField] GameObject L_To_R2;

    [SerializeField] GameObject win_UI;

    [SerializeField] GameObject slot3;
    [SerializeField] GameObject slot4;
    //[SerializeField] GameObject item3;



    //[SerializeField] Transform[] correct_slot;
    public void wincheck()
    {
        if (L_TO_R.transform.parent == slot1.transform &&
            L_To_B.transform.parent == slot2.transform &&
            T_TO_R.transform.parent == slot5.transform &&
            L_To_R2.transform.parent == slot6.transform &&
            !win_UI.gameObject.activeSelf)
        {
            Debug.Log("you win");
            win_UI.gameObject.SetActive(true);
        }
        else if (L_TO_R.transform.parent == slot1.transform &&
                L_To_R2.transform.parent == slot2.transform &&
                L_To_B.transform.parent == slot3.transform &&
                T_TO_R.transform.parent == slot6.transform &&
                !win_UI.gameObject.activeSelf)
        {
            Debug.Log("you win win win");
            win_UI.gameObject.SetActive(true);
        }
        else if(L_To_B.transform.parent == slot1.transform &&
                T_TO_R.transform.parent == slot4.transform &&
                L_TO_R.transform.parent == slot5.transform &&
                L_To_R2.transform.parent == slot6.transform &&
                !win_UI.gameObject.activeSelf)
        {
            Debug.Log("you win win win");
            win_UI.gameObject.SetActive(true);
        }
        else if (L_To_B.transform.parent == slot1.transform &&
                T_TO_R.transform.parent == slot4.transform &&
                L_To_R2.transform.parent == slot5.transform &&
                L_TO_R.transform.parent == slot6.transform &&
                !win_UI.gameObject.activeSelf)
        {
            Debug.Log("you win win win");
            win_UI.gameObject.SetActive(true);
        }




    }

    //private void Update()
    //{
    //    if (L_TO_R.transform.parent == slot1.transform && !win_UI.gameObject.activeSelf)
    //    {
    //        if (L_TO_R2.transform.parent == slot2.transform)
    //        {
    //            if (left_To_Bottom.transform.parent == slot3.transform)
    //            {
    //                if (top_To_Right.transform.parent == slot4.transform)
    //                {
    //                    Debug.Log("you win");
    //                    win_UI.gameObject.SetActive(true);
    //                }
    //            }
    //        }
    //    }
    //}


    //left_Pipe left_Pipel;
    //top_Pipe top_Pipel;
    //[SerializeField] GameObject win_UI;

    //private void Start()
    //{
    //    left_Pipel = GetComponent<left_Pipe>();
    //    top_Pipel = GetComponent<top_Pipe>();
    //}
    //private void Update()
    //{
    //    if (left_Pipel.leftConnection && top_Pipel.topConnection)
    //    {
    //        win_UI.gameObject.SetActive(true);
    //        Debug.Log("win");
    //    }

    //}

}
