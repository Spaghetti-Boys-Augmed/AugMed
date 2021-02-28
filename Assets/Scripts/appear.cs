using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class appear : MonoBehaviour
{

    public GameObject text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void OnEnable()
    {
        text.SetActive(false);
    }

    void OnDisable()
    {

        text.SetActive(true);
    }
}
