using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorScript : MonoBehaviour
{
    private float powerApplied=0f;
    public float recoverySpeed = 5f;
    private Transform tranDoor;
    private Vector3 originalPosition;
    private GameObject player;
    private Collider myCollider;

    // Start is called before the first frame update
    void Start()
    {
        tranDoor=this.GetComponent<Transform>();

        //Set original position
        originalPosition = tranDoor.position;

        myCollider=this.GetComponent<MeshCollider>();

        this.player = GameObject.FindWithTag("Player");
               
    }

    //Moves this GameObject recoverySpeed units a second towards its original position
    void Update()
    {        
        if (Vector3.Distance(tranDoor.position, originalPosition) >= 0.001f)
        {
            // Move our position a step closer to the target.
            float step = recoverySpeed * Time.deltaTime; // calculate distance to move
            tranDoor.position = Vector3.MoveTowards(transform.position, originalPosition, step);

        }
       
    }

    //On trigger collision, door is moved depending on car power
    private void OnTriggerEnter(Collider other)
    {
        powerApplied = GameObject.FindWithTag("PowerBar").GetComponent<Slider>().value;

        if (this.gameObject.tag == "FrontDoor")
        {
            //The FrontDoor moves on opposite direction than back one
            powerApplied = -powerApplied;
        }

        if (Vector3.Distance(tranDoor.position, originalPosition) < 0.001f)
        {           
            tranDoor.position = tranDoor.position + new Vector3(powerApplied*10, 0, 0);
        }

    }
}
