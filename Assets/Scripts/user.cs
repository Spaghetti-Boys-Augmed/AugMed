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
   
}
