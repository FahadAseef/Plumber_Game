using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class win_Checker_2 : MonoBehaviour
{
    [SerializeField] GameObject slot1;
    [SerializeField] GameObject L_TO_R;

    [SerializeField] GameObject slot2;
    [SerializeField] GameObject L_TO_B;

    [SerializeField] GameObject slot6;
    [SerializeField] GameObject L_R_B_T;

    [SerializeField] GameObject slot10;
    [SerializeField] GameObject T_T0_R;

    [SerializeField] GameObject slot11;
    [SerializeField] GameObject L_TO_R2;

    [SerializeField] GameObject slot12;
    [SerializeField] GameObject L_TO_R3;

    [SerializeField] GameObject win_UI;

    private void Update()
    {
        if (L_TO_R.transform.parent == slot1.transform)
        {
            if (L_TO_B.transform.parent == slot2.transform)
            {
                if (L_R_B_T.transform.parent == slot6.transform)
                {
                    if (T_T0_R.transform.parent == slot10.transform)
                    {
                        if(L_TO_R2.transform.parent == slot11.transform)
                        {
                            if(L_TO_R3.transform.parent == slot12.transform)
                            {
                                Debug.Log("you win");
                                win_UI.gameObject.SetActive(true);
                            }
                        }
                                     
                    }
                }
            }
        }
    }
}
