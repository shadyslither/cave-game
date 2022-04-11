using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hole : obj
{
    player plr;
    // Start is called before the first frame update
    void Start()
    {
     plr = GameObject.FindGameObjectWithTag("Player").GetComponent<player>();
    }

    // Update is called once per frame
    void Update()
    {
   
    }

    //overides obj method
    public void OnTriggerStay2D(Collider2D col)
    {
        
      //of player has rope
        if(col.tag == "Player" && plr.items[plr.helditem].name == "rope"){
            //teleport them to the hole area
            col.gameObject.transform.position = new Vector3(-79f, 10f, 1.0f);
            //tell them the fell down the hole
            text.text = newtext;
        }
        else{
            //else say they need a rope to go down the hole
            string j = "You dont't want to go down the hole without a rope!";
            text.text = j;
        }
    }
}
