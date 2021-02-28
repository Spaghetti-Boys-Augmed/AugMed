using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loadObj : MonoBehaviour
{
    public GameObject g1;
    public GameObject g2;
    public GameObject g3;
    public GameObject g4;
    public GameObject g5;
    public GameObject g6;
    public GameObject g7;
    public GameObject g8;
    public GameObject g9;
    public GameObject g10;

    // Start is called before the first frame update
    void Start()
    {
        string idObj = btnScript.btnF;

        switch (idObj)
        {
            case "1":
                g1.SetActive(true);
                break;
            case "2":
                g2.SetActive(true);
                break;
            case "3":
                g3.SetActive(true);
                break;
            case "4":
                g4.SetActive(true);
                break;
            case "5":
                g5.SetActive(true);
                break;
            case "6":
                g6.SetActive(true);
                break;
            case "7":
                g7.SetActive(true);
                break;
            case "8":
                g8.SetActive(true);
                break;
            case "9":
                g9.SetActive(true);
                break;
            case "10":
                g10.SetActive(true);
                break;

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
