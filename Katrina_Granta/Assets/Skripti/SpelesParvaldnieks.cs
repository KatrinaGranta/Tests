using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpelesParvaldnieks : MonoBehaviour
{
    public List<Jautajumi> jautajumi;
    public GameObject[] izvele;
    public int pasreizejaisJautajums;

    public GameObject JautajumuLogs;
    public GameObject RezultatuLogs;

    public Text jautajumuTeksts;
    public Text RezultatuTeksts;

    int jautajumuSkaits = 0;
    public int rezultats;

    private void Start()
    {
        jautajumuSkaits = jautajumi.Count;
        RezultatuLogs.SetActive(false);
        generetJautajumu();
    }

    void SpelesBeigas()
    {
        JautajumuLogs.SetActive(false);
        RezultatuLogs.SetActive(true);
        RezultatuTeksts.text ="Tu ieguvi: "+  rezultats + "/" + jautajumuSkaits;
    }

    public void pareizi()
    {
        rezultats += 1;
        jautajumi.RemoveAt(pasreizejaisJautajums);
        generetJautajumu();

    }

    public void nepareizi()
    {
        jautajumi.RemoveAt(pasreizejaisJautajums);
        generetJautajumu();
    }
    void Atbildes()
    {
        for(int i = 0; i< izvele.Length; i++)
        {
            izvele[i].GetComponent<AtbildesSkripts>().AtbildePareiza = false;
            izvele[i].transform.GetChild(0).GetComponent<Text>().text = jautajumi[pasreizejaisJautajums].atbildes[i];

            if (jautajumi[pasreizejaisJautajums].PareizaAtbilde == i + 1)
            {
                izvele[i].GetComponent<AtbildesSkripts>().AtbildePareiza = true;
            }
        }
    }
     void generetJautajumu()
    {
        if(jautajumi.Count > 0)
        {
            pasreizejaisJautajums = Random.Range(0, jautajumi.Count);
            jautajumuTeksts.text = jautajumi[pasreizejaisJautajums].Jautajums;
            Atbildes();
        }
        else
        {
            Debug.Log("Nav vairs jautājumu");
            SpelesBeigas();
        }
    }

}

  