using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.XR.ARFoundation;
using UnityEngine.Events;
using UnityEngine.XR.ARSubsystems;

public class objectSelect : MonoBehaviour
{
    ARTrackedImageManager ARTracked;
    ARTrackedImagesChangedEventArgs eventArgs;

    [SerializeField]
    private GameObject A;
    [SerializeField]
    private GameObject B;

    // Start is called before the first frame update
    void Start()
    {
        ARTracked = GameObject.Find("AR Session Origin").AddComponent<ARTrackedImageManager>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(eventArgs.removed);
        if (eventArgs.removed != null)
        {
            ARTracked.trackedImagePrefab = A;
            //("none")
        }
        else
        {
            ARTracked.trackedImagePrefab = B;
        }
    }
}
