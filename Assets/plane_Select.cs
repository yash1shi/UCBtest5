using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plane_Select : MonoBehaviour
{
    private int num=0;
    int A;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Switch()
    {
        if (num == 0)
        {
            num=1;

        }
        else{
            num = 0;
        }
    }


    public int Select
    {
        get { return this.num; }
        set { this.num = value; }
    }
}
