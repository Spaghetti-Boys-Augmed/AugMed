using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vumarkTracker : MonoBehaviour
{
    public VuMarkTarget vumark;

    private VuMarkManager mVuMarkManager;

    void Start ()

    {

        mVuMarkManager = TrackerManager.Instance.GetStateManager().GetVuMarkManager();

    }

    void Update ()

    {

        foreach (var bhvr in mVuMarkManager.GetActiveBehaviours())

        {

            vumark = bhvr.VuMarkTarget;

            var VuId = vumark.InstanceId;

            print ("Found ID number " + VuId);

            foreach (Transform child in transform)

            {

           

                if (child.name == VuId.ToString())

                {

                    child.gameObject.SetActive (true);

                }

                else

                {

                    child.gameObject.SetActive(false);

                }

            }

        }

    }
}
