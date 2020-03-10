using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Animator animator;
    public GameObject crossHair;
    public GameObject bulletPrefab;



    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movment = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0.0f);

        MoveCrossHair();

        animator.SetFloat("Horizontal", movment.x);
        animator.SetFloat("Vertical", movment.y);
        animator.SetFloat("Magnitude", movment.magnitude);

        transform.position = transform.position + movment * Time.deltaTime;
    }

    private void MoveCrossHair()
    {
        Vector3 aim = new Vector3(Input.GetAxis("AimHorizontal"), Input.GetAxis("AimVertical"), 0.0f);

        if (aim.magnitude > 0.0f)
        {
            aim.Normalize();
            aim *= 0.4f;
            crossHair.transform.localPosition = aim;
        }
        else
        {
            crossHair.SetActive(false);
        }


    }
}
