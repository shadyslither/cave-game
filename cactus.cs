using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//inherits from
public class cactus : obj
{

    player plr;
    // Start is called before the first frame update

    public GameObject ply;
    void Start()
    {
        pushable = false;
        //gets the script for the player
        plr = GameObject.FindGameObjectWithTag("Player").GetComponent<player>();
    }

    // Update is called once per frame
    void Update()
    {
        
        //if something touhes it and player doesnt have glove
        if(tch==true && pushable == false){
           ///then push the player
             ply.transform.position = new Vector3(1.0f, 1.0f, 1.0f);
             //and say the rock is no longer being touched
             tch = false;
             
        }
        tch=false;
    
        {
        
        }
        //if the player is holding the glove
        if(plr.items[plr.helditem].name == "glove"){
            //allow the cactus to be pushed
            pushable = true;
        }else{
            pushable = false;
        }
    }
}
