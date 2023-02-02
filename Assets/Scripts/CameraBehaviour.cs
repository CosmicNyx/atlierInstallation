using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetAxis("Mouse Y") < 0)
        {
            transform.Rotate(180 * Time.deltaTime, 0, 0, Space.Self);
        }
        if (Input.GetAxis("Mouse Y") > 0)
        {
            transform.Rotate(-180 * Time.deltaTime, 0, 0, Space.Self);
        }
    }
}
