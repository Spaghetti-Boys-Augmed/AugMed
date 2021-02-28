using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class voltarDashboard : MonoBehaviour
{

    public Button sendBtn;
    public int btnValue;
    static public int sndVl;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = sendBtn.GetComponent<Button>();

        btn.onClick.AddListener(changeSceneBtn);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void changeSceneBtn()
    {

        Debug.Log("funciona");
        SceneManager.LoadScene("Scenes/Dashboard", LoadSceneMode.Single);

    }
}
