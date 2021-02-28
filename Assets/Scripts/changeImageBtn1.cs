using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeImageBtn1 : MonoBehaviour
{
    public Button btnI;
    public Sprite withSound;
    public Sprite withthoutSound;
    private bool som = false;
    public AudioSource audio;

     void Start()
    {
       /* Button btn = btnI.GetComponent<Button>();
        btn.onClick.AddListener(OnButtonClick);*/
    
    }

     void Update()
    {
        
    }


    public void OnButtonClick()
    {
      
        if(som == false)
        {
            som = true;
            btnI.image.sprite = withthoutSound;
            Debug.Log("with");
            audio.Play();
        }
        else
        {
            som = false;
            btnI.image.sprite = withSound;
            Debug.Log("without");
            audio.Pause();
        }

    

    }
}
