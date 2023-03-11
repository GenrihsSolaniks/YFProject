using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class headBobbingScript : MonoBehaviour
{

    public GameObject Camera;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            StartBobbing();
        }
    }

    void StartBobbing()
    {
        Camera.GetComponent<Animator>().Play("HeadBobbing");
    }

    public void StopBobbing()
    {
        Camera.GetComponent<Animator>().Play("New State");
    }
}