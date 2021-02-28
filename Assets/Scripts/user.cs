using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class user 
{

    public string userName;
    public string email;
    public  List<String> fav = new List<String>();
    public user(string aUsername, string aEmail)
    {
        userName = aUsername;
        email = aEmail;
    }

    public string GetEmail()
    {
        return email;
    }

    public void setFav(String btnFav)
    {
        Debug.Log("setPassed");
        fav.Add(btnFav);
    }

    public int findFav(String btnFav)
    {
        foreach (String favs in fav)
        {
            Debug.Log(favs);
            if (favs == btnFav)
            {
                return 1;
            }
        }
        return 0;
    }


    public void printFav()
    {
        foreach (String favs in fav)
        {
            Debug.Log("ssfs");
            Debug.Log(favs);
        }
    }
    public void removeFav(String btnFav)
    {
        var index = fav.FindIndex(i => i == btnFav);
        if (index >= 0) {
            fav.RemoveAt(index);
        }
    }

    public void toString()
    {
        foreach (String favs in fav)
        {
            Debug.Log(userName + " " + email + " " + favs); 
        }
    }
}