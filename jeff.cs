using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jeff : MonoBehaviour
{
    public GameObject j;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if space bar is pressed make this screen go away
         if (Input.GetKeyDown("space")==true)
        {
            j.SetActive(false);
        
        }
    }
}
