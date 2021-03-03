using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using UnityEditor;

//[RequireComponent(typeof(ARRaycastManager))]
public class SelectObj2 : MonoBehaviour
{

    public GameObject First;
    ARfoundation ARF;

    public GameObject B2;
    // Start is called before the first frame update
    void Start()
    {
        ARF = First.GetComponent<ARfoundation>();
    }

    public void onClick1()
    {
        ARF.objectPrefab = B2;
    }
}
