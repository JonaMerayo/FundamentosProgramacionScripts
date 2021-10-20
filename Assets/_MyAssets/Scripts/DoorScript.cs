using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    private Transform tranDoor;
    private float powerApplied=30f;
    public float recoverySpeed = 5f;
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

        if (this.gameObject.tag == "FrontDoor")
        {
            //The FrontDoor moves on opposite direction than back one
            powerApplied = -powerApplied;
        }
    }

    ////Moves this GameObject recoverySpeed units a second towards its original position
    //void fixedUpdate()
    //{
    //    if (Vector3.Distance(tranDoor.position, originalPosition) >= 0.001f)
    //    {
    //        // Move our position a step closer to the target.
    //        tranDoor.Translate(Vector3.forward * Time.deltaTime * recoverySpeed);
    //    }        

    //}

    //Moves this GameObject recoverySpeed units a second towards its original position
    void Update()
    {        
        if (Vector3.Distance(tranDoor.position, originalPosition) >= 0.001f)
        {
            // Move our position a step closer to the target.
            float step = recoverySpeed * Time.deltaTime; // calculate distance to move
            tranDoor.position = Vector3.MoveTowards(transform.position, originalPosition, step);

            //And disable collider until it reachs position original
            //myCollider.isTrigger = false;
        }
        //else if (myCollider.isTrigger==false)//Para que no este cambiandolo continuamente
        //{
        //    //Enabled again on position original.
        //    myCollider.isTrigger = true;
        //}
    }

    //On trigger collision, door is moved depending on car power
    private void OnTriggerEnter(Collider other)
    {
        if (Vector3.Distance(tranDoor.position, originalPosition) < 0.001f)
        {           
            tranDoor.position = tranDoor.position + new Vector3(powerApplied, 0, 0);
        }

        ////Reset player position to the center
        //player.transform.position = new Vector3(0, 0, 0);
    }
}
