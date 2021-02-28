using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class addNew : MonoBehaviour
{
    public Button btnI;
    public Text brevementeText;

    void Start()
    {
        Button btn = btnI.GetComponent<Button>();
        btn.onClick.AddListener(OnButtonClick);
    }

    void Update()
    {

    }


    public void OnButtonClick()
    {

       // Debug.Log(user);
        brevementeText.text = "Brevemente!!";

      
    }
}
