using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

[RequireComponent(typeof(ARRaycastManager))]

public class plane_ARf : MonoBehaviour
{

    public GameObject objectPrefab;
    public TrackableType type;

    ARRaycastManager raycastManager;
    List<ARRaycastHit> hitResults = new List<ARRaycastHit>();

    RaycastHit[] hit =new RaycastHit[1];

    plane_Select ps;
    private int sw;

    int flag = 0;
    float rotatey = 0;


    void Start()
    {
        raycastManager = GetComponent<ARRaycastManager>();
        ps = GameObject.Find("Button").GetComponent<plane_Select>();

    }





    void Update()
    {
        sw = ps.Select;
        //Vector3 touchPos = Input.GetTouch(0).position;
        //Ray ray = Camera.main.ScreenPointToRay(touchPos);

        if (sw == 0)
        {

            if (raycastManager.Raycast(Input.GetTouch(0).position, hitResults, TrackableType.All))
            {
                if (Input.GetMouseButtonDown(0))
                {
                    Instantiate(objectPrefab, hitResults[0].pose.position, Quaternion.identity);
                }
            }


        }
        else
        {
            //if(raycastManager.Raycast(Input.GetTouch(0).position, hitResults, TrackableType.All))
            //{
            //    Pose pose = hitResults[0].pose;
            //    int hitnum=Physics.RaycastNonAlloc(ray,hit);
            //    if (hitnum > 0)
            //    {
            //        rotatey += Time.deltaTime * 40;
            //        hit[0].transform.localRotation = Quaternion.Euler(0, rotatey, 0);
            //    }
            //}
        }

    }
}
