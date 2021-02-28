using System;
using UnityEngine;
using UnityEngine.UI;

namespace Script
{
    public class RotateObjF : MonoBehaviour
    {
        public float y;
        public GameObject model;
        public GameObject model2;
        public GameObject model3;
        public GameObject model4;
        public GameObject model5;
        public GameObject model6;
        public GameObject model7;
        public GameObject model8;
        public GameObject model9;
        public GameObject model10;
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
            
            Vector3 tempRotation6 = model6.transform.eulerAngles;
            tempRotation6.y = y;
            model6.transform.rotation = Quaternion.Euler (tempRotation6);
            
            Vector3 tempRotation7 = model7.transform.eulerAngles;
            tempRotation7.y = y;
            model7.transform.rotation = Quaternion.Euler (tempRotation7);
            
            Vector3 tempRotation8 = model8.transform.eulerAngles;
            tempRotation8.y = y;
            model8.transform.rotation = Quaternion.Euler (tempRotation8);
            
            Vector3 tempRotation9 = model9.transform.eulerAngles;
            tempRotation9.y = y;
            model9.transform.rotation = Quaternion.Euler (tempRotation9);
            
            Vector3 tempRotation10 = model10.transform.eulerAngles;
            tempRotation10.y = y;
            model10.transform.rotation = Quaternion.Euler (tempRotation10);
        }
    }
    
}
