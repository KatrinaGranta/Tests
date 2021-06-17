using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtbildesSkripts : MonoBehaviour
{
    public bool AtbildePareiza = false;
    public SpelesParvaldnieks spelesParvaldnieks;
    public void Atbildes()
    {
        if (AtbildePareiza)
        {
            Debug.Log("Pareiza Atbilde");
            spelesParvaldnieks.pareizi();
        }
        else
        {
            Debug.Log("Nepareiza Atbilde");
            spelesParvaldnieks.nepareizi();

        }
    }


}
