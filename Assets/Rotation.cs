using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    private plane_Select ps2;
    int sw2;

    float rotatey = 0;
    // Start is called before the first frame update
    void Start()
    {
        ps2 = GameObject.Find("Button").GetComponent<plane_Select>();
    }

    // Update is called once per frame
    void Update()
    {
        sw2 = ps2.Select;
        //var touch = Input.touches[0];
        //if (sw2 == 1)
        //{
        //    if (touch.phase == TouchPhase.Moved)
        //    {
        //        rotatey += Time.deltaTime * 40;
        //        this.gameObject.transform.localRotation = Quaternion.Euler(0, rotatey, 0);
        //    }
        //}
        //else
        //{

        //}

    }

    public void touchobj()
    {
        if (sw2 == 1)
        {
            var touch = Input.touches[0];
            if (touch.phase == TouchPhase.Moved)
            {
                rotatey += Time.deltaTime * 40;
                this.gameObject.transform.localRotation = Quaternion.Euler(0, rotatey, 0);
            }

        }
    }
}
