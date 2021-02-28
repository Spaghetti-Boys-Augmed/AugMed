using System;
using System.Collections;
using System.Collections.Generic;
using Proyecto26;
using UnityEngine;
using UnityEngine.UI;

public class listModels : MonoBehaviour
{
    // Start is called before the first frame update
    public Button btn1;
    public Button btn2;
    public Button btn3;
    public Button btn4;
    public Button btn5;
    public Button btn6;
    public static String b1;
    public static String b2;
    public static String b3;
    public static String b4;
    public static String b5;
    public static String b6;

    // private user user = new user("dfsdf", "123@asda.com");
    private user user = auth.user;
    void Start()
    {
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);
        btn4.gameObject.SetActive(false);
        btn5.gameObject.SetActive(false);
        btn6.gameObject.SetActive(false);
        String index;
        
        RestClient.Get<user>("https://augmed-b88b9-default-rtdb.firebaseio.com/" + user.userName + ".json").Then(
            response =>
            {
                int i = 1;
                user.printFav();
                user = response;
                foreach (String favs in user.fav)
                {
                    if (favs!=null)
                    {
                        if (i==1)
                        {
                            btn1.gameObject.SetActive(true);
                            btn1.GetComponentInChildren<Text>().text = switchList(favs);
                            b1 = favs;
                            i++;
                        }
                        else if (i==2)
                        {
                            btn2.gameObject.SetActive(true);
                            btn2.GetComponentInChildren<Text>().text = switchList(favs);
                            b2 = favs;
                            i++;
                        }
                        else if (i==3)
                        {
                            btn3.gameObject.SetActive(true);
                            btn3.GetComponentInChildren<Text>().text = switchList(favs);
                            b3 = favs;
                            i++;
                        }
                        else if (i==4)
                        {
                            btn4.gameObject.SetActive(true);
                            btn4.GetComponentInChildren<Text>().text = switchList(favs);
                            b4 = favs;
                            i++;
                        }
                        else if (i==5)
                        {
                            btn5.gameObject.SetActive(true);
                            btn5.GetComponentInChildren<Text>().text = switchList(favs);
                            b5 = favs;
                            i++;
                        }
                        else if (i==6)
                        {
                            btn6.gameObject.SetActive(true);
                            btn6.GetComponentInChildren<Text>().text = switchList(favs);
                            b6 = favs;
                            i++;
                        }

                    }
                   
                }  
            });
    }
    
    
    
    
    public String switchList(String favs)
    {
     switch(favs){
         case "1":
             return "coracao";
             break;
         case "2":
             return "pulmoes";
             break;
         case "3":
             return "cerebro";
             break;
         case "4":
             return "Esqueleto";
             break;
         case "5":
             return "olho";
             break;
         case "6":
             return "neuronio";
         break;
         case "7":
             return "molecula";
             break;
         case "8":
             return "DNA";
             break;
         case "9":
             return "covid";
             break;
         case "10":
             return "Reagente";
             break;

     }

     return null;
    }

    
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
