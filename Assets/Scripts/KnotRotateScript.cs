using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnotRotateScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localEulerAngles = transform.localEulerAngles + new Vector3(5f, 0f, 5f) * Time.deltaTime;
    }
}
