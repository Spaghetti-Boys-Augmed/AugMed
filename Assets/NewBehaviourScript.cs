using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class NewBehaviourScript : MonoBehaviour
{

    public Button goToSceneRegisto;
    public int btnValue;
  
    // Start is called before the first frame update
    void Start()
    {
        Button btn = goToSceneRegisto.GetComponent<Button>();
        btn.onClick.AddListener(changeScene);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void changeScene()
    {
        
        SceneManager.LoadScene("Scenes/Registo", LoadSceneMode.Single);
    }
}
