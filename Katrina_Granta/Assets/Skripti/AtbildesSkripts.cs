using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtbildesSkripts : MonoBehaviour
{
    public bool AtbildePareiza = false;
    public SpelesParvaldnieks spelesParvaldnieks;

    public void Atbilde()
    {
        if (AtbildePareiza)
        {
            Debug.Log("Jautājums atbildēts pareizi!");
            spelesParvaldnieks.pareizi();
        }
        else
        {
            Debug.Log("Jautājums atbildēts nepareizi");
            spelesParvaldnieks.nepareizi();
        }
    }
}
