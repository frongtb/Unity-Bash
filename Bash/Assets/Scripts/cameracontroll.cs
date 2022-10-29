using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracontroll : MonoBehaviour
{
    public GameObject FrontView;
    public GameObject RealView;
    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = RealView.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            this.transform.position = Vector3.Lerp(this.transform.position,FrontView.transform.position,0.05f);
        }
        else
        {
            this.transform.position = Vector3.Lerp(this.transform.position, RealView.transform.position, 0.05f);
        }
    }
}
