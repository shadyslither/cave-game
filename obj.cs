using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//class / script in charge of the objects
public class obj : MonoBehaviour
{
    //what we what to change the text on screen to be
     public string newtext;
     public Collider2D coll;
     //getting the text on screen object

    protected bool tch;
     public Text text; 
     protected bool pushable = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tch = false;
    }
    //on trigger thing runs when something runs into the current obj
    public void OnTriggerStay2D(Collider2D col)
    {
         tch = true;
       text.text = newtext;
        if(pushable == true && col.tag != "item"){
//this whole thing just pushes the currenct object away from the player if they run into it
      //float x is the  x distance of the currecct object and the object that just ran into it
            float x = col.transform.position.x - transform.position.x;
            coll = col;
        //float y is the same thing but with y
            float y = col.transform.position.y - transform.position.y;
            //now it draws a vector with these points / distance
            Vector2 direction = new Vector2(x, y);
            //add force to this object 
            gameObject.GetComponent<Rigidbody2D>().AddForce(-direction * 50 * 50);
            //a is being touched variable for other methods
      
          //changes the text for current pop up text to be whatever this object, for example a cactus might say "you got poked"
       
        }
    }
        

          

        
      

}

