using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeImageBtn : MonoBehaviour
{
    public Button btnI;
    public Sprite myLockImage;

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
        //  lockComp = lockBtn.GetComponent<Image>();
        /*   if (bestScore >= 10)
           {
               lockComp.sprite = myLockImage;
           }
           else
           {
               lockComp.sprite = myLockSecondImage;
           }*/

        // Debug.Log("sefsf");

        /* Text txt = transform.Find("Text").GetComponent<Text>();
         txt.text = text;*/


        btnI.image.sprite = myLockImage;

    }
}
