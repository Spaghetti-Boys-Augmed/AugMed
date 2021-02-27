using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase;
using Firebase.Auth;
using Proyecto26;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class auth : MonoBehaviour
{
   
    
    [Header("Firebase")]
    public DependencyStatus dependencyStatus;
    public FirebaseAuth authManager;    
    public FirebaseUser User;

    [Header("Login")]
    public InputField emailLoginField;
    public InputField passwordLoginField;
    public Text warningLoginText;
    
    [Header("Register")]
    public InputField usernameRegisterField;
    public InputField  emailRegisterField;
    public InputField  passwordRegisterField;
    public Text warningRegisterText;

    public static user user;
   public void Awake()
    {
        
        FirebaseApp.CheckAndFixDependenciesAsync().ContinueWith(task =>
        {
            dependencyStatus = task.Result;
            if (dependencyStatus == DependencyStatus.Available)
            {
                
                InitializeFirebase();
            }
            else
            {
                Debug.LogError("Could not resolve all Firebase dependencies: " + dependencyStatus);
            }
        });
    }
   
   private void InitializeFirebase()
   {
       Debug.Log("Setting up Firebase Auth");
       
       authManager = FirebaseAuth.DefaultInstance;
   }
    
   public void LoginButton()
   {
      
       StartCoroutine(Login(emailLoginField.text, passwordLoginField.text));
       
   }
   
   
   private IEnumerator Login(string _email, string _password)
   {
       
       var LoginTask = authManager.SignInWithEmailAndPasswordAsync(_email, _password);
      
       yield return new WaitUntil(predicate: () => LoginTask.IsCompleted);

       if (LoginTask.Exception != null)
       {
          
           Debug.LogWarning(message: $"Failed to register task with {LoginTask.Exception}");
           Debug.LogWarning(_password);
           FirebaseException firebaseEx = LoginTask.Exception.GetBaseException() as FirebaseException;
           AuthError errorCode = (AuthError)firebaseEx.ErrorCode;
           
           string message = "Login Falhou!";
           switch (errorCode)
           {
               case AuthError.MissingEmail:
                   message = "Falta o Email";
                   break;
               case AuthError.MissingPassword:
                   message = "Falta a Password";
                   break;
               case AuthError.WrongPassword:
                   message = "Falta a Password";
                   break;
               case AuthError.InvalidEmail:
                   message = "Falta a Email";
                   break;
               case AuthError.UserNotFound:
                   message = "Esta conta não Existe";
                   break;
           }
           warningLoginText.text = message;
       }
       else
       {
           
           User = LoginTask.Result;
           Debug.LogFormat("User signed in successfully: {0} ({1})", User.DisplayName, User.Email);
      
           warningLoginText.text = "";
           warningLoginText.text = "User não logado";
       }
   }
   
   
   //Function for the register button
   public void RegisterButton()
   {
       //Call the register coroutine passing the email, password, and username
       StartCoroutine(Register(emailRegisterField.text, passwordRegisterField.text, usernameRegisterField.text));
   }
   
   private IEnumerator Register(string _email, string _password, string _username)
    {
        if (_username == "")
        {
            //If the username field is blank show a warning
            warningRegisterText.text = "Missing Username";
        }
        else 
        {
            //Call the Firebase auth signin function passing the email and password
            var RegisterTask = authManager.CreateUserWithEmailAndPasswordAsync(_email, _password);
            //Wait until the task completes
            yield return new WaitUntil(predicate: () => RegisterTask.IsCompleted);

            if (RegisterTask.Exception != null)
            {
                //If there are errors handle them
                Debug.LogWarning(message: $"Failed to register task with {RegisterTask.Exception}");
                FirebaseException firebaseEx = RegisterTask.Exception.GetBaseException() as FirebaseException;
                AuthError errorCode = (AuthError)firebaseEx.ErrorCode;

                string message = "Register Failed!";
                switch (errorCode)
                {
                    case AuthError.MissingEmail:
                        message = "Falta o Email";
                        break;
                    case AuthError.MissingPassword:
                        message = "Falta a Password";
                        break;
                    case AuthError.WeakPassword:
                        message = "A Password e Fraca";
                        break;
                    case AuthError.EmailAlreadyInUse:
                        message = "Email ja esta a ser utilizado";
                        break;
                }
                warningRegisterText.text = message;
            }
            else
            {
                //User has now been created
                //Now get the result
                User = RegisterTask.Result;

                if (User != null)
                {
                    //Create a user profile and set the username
                    UserProfile profile = new UserProfile{DisplayName = _username};

                    //Call the Firebase auth update user profile function passing the profile with the username
                    var ProfileTask = User.UpdateUserProfileAsync(profile);
                    //Wait until the task completes
                    yield return new WaitUntil(predicate: () => ProfileTask.IsCompleted);

                    if (ProfileTask.Exception != null)
                    {
                        //If there are errors handle them
                        Debug.LogWarning(message: $"Registo falhou {ProfileTask.Exception}");
                        FirebaseException firebaseEx = ProfileTask.Exception.GetBaseException() as FirebaseException;
                        AuthError errorCode = (AuthError)firebaseEx.ErrorCode;
                        warningRegisterText.text = "Username invalido";
                    }
                    else
                    {
                        user= new user(_username,_email);
                        RestClient.Put("https://augmed-b88b9-default-rtdb.firebaseio.com/"+user.userName+".json",
                            user);
                        Debug.LogWarning(_email+" "+user);
                        SceneManager.LoadScene("Scenes/Login", LoadSceneMode.Single);
                        warningRegisterText.text = "";
                    }
                }
            }
        }
    }
    
}