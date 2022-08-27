using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//name has changed from ConsolePrint 
public class PrintAndHide : MonoBehaviour
{
    public int i;
    public Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        i = 3;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(gameObject.name + ":" + ++i);

        //100%
        if(gameObject.tag == "Red" && i == 100)
        {
            gameObject.SetActive(false);
        }
        if(gameObject.tag == "Blue" && i == Random.Range(200, 251))
        {
            rend.enabled = false;
        }
    }
}
