using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class old : obj
{
    player plr;
    GameObject win;
    // Start is called before the first frame update
    void Start()
    {
        //oldman cannot be pushed
        pushable = false;
        //gets player variables
        plr = GameObject.FindGameObjectWithTag("Player").GetComponent<player>();
        win = GameObject.FindGameObjectWithTag("win");
    }

    // Update is called once per frame
    void Update()
    {
        if(tch && plr.items[plr.helditem].name == "shiny"){
            Debug.Log(win);
            win.GetComponent<SpriteRenderer>().sortingOrder = 10;

        }else{
            tch = false;
        }
    }
}
