using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crosshair : MonoBehaviour
{
    public GameObject crosshairs;
    private Vector3 target;



    // Start is called before the first frame update
    void Start()
    {
        target = transform.GetComponent<Camera>().ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z));
        crosshairs.transform.position = new Vector2(target.x, target.y);
    }

    // Update is called once per frame
    void Update()
    {

    }
}

