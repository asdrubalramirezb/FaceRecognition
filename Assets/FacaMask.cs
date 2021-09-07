using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleARCore;

public class FacaMask : MonoBehaviour
{
   
    public GameObject faceMask;   
    private List<AugmentedFace> _tempFaceMask = new List<AugmentedFace>();
    // Update is called once per frame
    void Update()
    {
        Session.GetTrackables<AugmentedFace>(_tempFaceMask, TrackableQueryFilter.All);
        if (_tempFaceMask.Count == 0)
        {
            faceMask.SetActive(false);
        }
        else
        {
            faceMask.SetActive(true);
        }

    }
}
