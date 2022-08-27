using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAssets : MonoBehaviour
{
    public GameObject redObj;
    [SerializeField]
    private GameObject blueObj;
    //red and blue object placement 
    Vector3 objectPos;

    // Start is called before the first frame update
    void Start()
    {
        objectPos = new Vector3(2, 0, 0);
        Instantiate(redObj, objectPos, Quaternion.identity);
        objectPos = new Vector3(-2, 0, 0);
        Instantiate(blueObj, objectPos, Quaternion.identity);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
