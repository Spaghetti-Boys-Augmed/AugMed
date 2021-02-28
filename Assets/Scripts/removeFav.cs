using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Proyecto26;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class removeFav : MonoBehaviour
{
    public Button fav;
   

    // private user user = new user("dfsdf", "123@asda.com");
    private user user = auth.user;
    void Start()
    {
        Button btn = fav.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);

    }

    // Update is called once per frame
    void Update()
    {

    }

    void TaskOnClick()
    {
        RestClient.Get<user>("https://augmed-b88b9-default-rtdb.firebaseio.com/" + user.userName + ".json").Then(
            response =>
            {
                Debug.Log("Passed");
                user = response;
                user.toString();
                int rep = user.findFav(btnScript.btnF);

                if (rep == 1)
                {
                 
                    Debug.Log("Removido");
                    user.removeFav(btnScript.btnF);
                    user.toString();
                    RestClient.Put("https://augmed-b88b9-default-rtdb.firebaseio.com/" + user.userName + ".json", user);
                    SceneManager.LoadScene("Scenes/Favoritos", LoadSceneMode.Single);
                }
            });
    }
}
