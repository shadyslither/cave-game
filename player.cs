using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//class that deals with all player stuff
public class player  : MonoBehaviour
{
//what t


//getting the object that displays text unto screen
     public Text text; 

    // Start is called before the first frame update
    //array of all the items the player has
public GameObject[] items = new GameObject[5];
//gets animator so it can animate the right animations

public Animator anim;


//the left most slot in the array 
public int emptySlot = 0;

public int helditem = 0;
GameObject empt;
//getting the rigidbody object aka the physics for object
    private Rigidbody2D rb;
    //speed variable is just a modifier of how fast the player should go
    public int speed;
    void Start()
    {
          //actually asiign the rigid body here
        rb = GetComponent<Rigidbody2D>();
            for(int i = 0; i < items.Length; i++){
                  items[i] = empt;
            }
    }

    // Update is called once per frame
    void Update()
    {

          if (Input.GetKeyDown("space")){
             if(items[helditem] == empt){
                    helditem=0;
              }
              else{
                 items[helditem].SetActive(false);
                    
            helditem++;
              }
          }
          //movement script if key is w, go up etc..
        if (Input.GetKey("w"))
        {
            anim.SetBool("up", true);
            //moving player up
              rb.AddForce(new Vector2(0,speed));
              
        }else{
              anim.SetBool("up", false);
        }
        if (Input.GetKey("d"))
        {
              anim.SetBool("goingRight", true);
            //moving player left etc etc
              rb.AddForce(new Vector2(speed,0));
        }else{
              anim.SetBool("goingRight", false);
        }
        if (Input.GetKey("s"))
        {
            anim.SetBool("idle", true);
              rb.AddForce(new Vector2(0,-speed));
        }else{
               anim.SetBool("idle", false);
        }
        if (Input.GetKey("a"))
        {
            anim.SetBool("goingLeft", true);
              rb.AddForce(new Vector2(-speed,0));
        }else{
               anim.SetBool("goingLeft", false);
        }
//if the player has picked up an item
      if(emptySlot != 0 ){
          //transport that item slightly to the right of the player
            items[helditem].transform.position = new Vector3(gameObject.transform.position.x-0.3f, gameObject.transform.position.y-0.2f, 0);
           //make the item visible
            items[helditem].SetActive(true);
      }
      
      
    }
//when player runs into something
     public void OnTriggerStay2D(Collider2D col)
    {
          //if that it ran into an item
          if(col.gameObject.tag == "item"){
       
                // tell them they found an item
          text.text = "You found a " + col.gameObject.name + "!";
          //add item to item list
          items[emptySlot] = col.gameObject;

          //make the item dissaper
          col.gameObject.SetActive(false);
          //turn off its hitbox so i cant run into it anymore
          col.gameObject.GetComponent<BoxCollider2D>().enabled = false;
          //add the next itemto the next array slot
          emptySlot++;

    }
        
    }
    
}
