using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class btnScript : MonoBehaviour
{
    public Button btn;

    public int btnId;

    public static String btnF;
    // Start is called before the first frame update
    void Start()
    {
        
        Button b =btn.GetComponent<Button>();
        b.onClick.AddListener(TaskOnClick);
    }
    
    void TaskOnClick()
    {
        switch (btnId)
        {
            case 1:
                btnF = listModels.b1;
                break;
            case 2:
                btnF = listModels.b2;
                break;
            case 3:
                btnF = listModels.b3;
                break;
            case 4:
                btnF = listModels.b4;
                break;
            case 5:
                btnF = listModels.b5;
                break;
            case 6:
                btnF = listModels.b6;
                break;
        }
        SceneManager.LoadScene("Scenes/favE", LoadSceneMode.Single);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
