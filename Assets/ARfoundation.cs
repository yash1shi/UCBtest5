using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
public class ARfoundation : MonoBehaviour
{

    public GameObject objectPrefab;//生成するオブジェクト
    private ARRaycastManager raycastManager;
    private List<ARRaycastHit> raycastHitList = new List<ARRaycastHit>();
    void Start()
    {
        raycastManager = GetComponent<ARRaycastManager>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase != TouchPhase.Ended)
            {
                return;
            }
            if (raycastManager.Raycast(touch.position, raycastHitList, TrackableType.All))
            {
                Debug.Log("Raycast成功");
                Instantiate(objectPrefab, raycastHitList[0].pose.position, Quaternion.identity);

            }
            else
            {
                Debug.Log("Raycast失敗");
            }
        }

    }
}

//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.XR.ARFoundation;
//using UnityEngine.XR.ARSubsystems;
//using UnityEditor;

////[RequireComponent(typeof(ARRaycastManager))]
//public class ARfoundation : MonoBehaviour
//{



//    public GameObject objectPrefab;

//    public TrackableType type;

//    ARRaycastManager raycastManager;
//    List<ARRaycastHit> hitResults = new List<ARRaycastHit>();

//    // RaycastHit hit;

//     int flag = 0;
//    float rotatey = 0;
//    void Start()
//    {
//        raycastManager = GetComponent<ARRaycastManager>();
//    }



//    ARRaycastHit hit = new ARRaycastHit();

//    void Update()
//    {
//        if (flag == 0)
//        {
//            //if (Input.GetMouseButtonDown(0))
//            // {
//            // if(Physics.Raycast())
//            if (raycastManager.CompareTag("Player"))
//            {
//                rotatey += Time.deltaTime * 20;
//                // hit.//= Quaternion.Euler(0, rotatey, 0);//transform.localRotation = Quaternion.Euler(0, rotatey, 0);



//            }
//            else
//            {
//                if (Input.GetMouseButtonDown(0))
//                {
//                    if (raycastManager.Raycast(Input.GetTouch(0).position, hitResults, TrackableType.All))
//                    {
//                        Instantiate(objectPrefab, hitResults[0].pose.position, Quaternion.identity);
//                    }
//                    flag = 1;


//                }

//            }
//            //flag = 1;
//        }
//    }
//}
