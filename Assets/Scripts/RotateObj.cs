using System;
using UnityEngine;
using UnityEngine.UI;

namespace Script
{
    public class RotateObj : MonoBehaviour
    {
        public float y;
        public GameObject model;
        public GameObject model2;
        public GameObject model3;
        public GameObject model4;
        public GameObject model5;
        public Slider mainSlider;

        private void Start()
        {
            mainSlider.onValueChanged.AddListener(delegate {ValueChangeCheck(); });
        }

        public void changeY(float newY)
        {
            y = newY;
            Debug.Log(y);
            
        }
    
        void Update()
        {

            
            
        }
        
        public void ValueChangeCheck()
        {
            Vector3 tempRotation = model.transform.eulerAngles;
            tempRotation.y = y;
            model.transform.rotation = Quaternion.Euler (tempRotation);
            
            Vector3 tempRotation2 = model2.transform.eulerAngles;
            tempRotation2.y = y;
            model2.transform.rotation = Quaternion.Euler (tempRotation2);
            
            Vector3 tempRotation3 = model3.transform.eulerAngles;
            tempRotation3.y = y;
            model3.transform.rotation = Quaternion.Euler (tempRotation3);
            
            Vector3 tempRotation4 = model4.transform.eulerAngles;
            tempRotation4.y = y;
            model4.transform.rotation = Quaternion.Euler (tempRotation4);
            
            Vector3 tempRotation5 = model5.transform.eulerAngles;
            tempRotation5.y = y;
            model5.transform.rotation = Quaternion.Euler (tempRotation5);
        }
    }
    
}
