using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeScripts : MonoBehaviour
{
    public float extraForce = 1;
    public float power = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        // If the object that hit us is the Player
        if (col.gameObject.tag == "Player")
        {
            // Store force to add
            Vector3 forceToAdd = calculateForceToApply(col);

            // Add force. This will push forward the cube
            GetComponent<Rigidbody>().AddForce(forceToAdd);
            //Debug.Log("Fuerza aplicada a cubo: " + forceToAdd);

            //Reduce object size while size and color
            reduceObjectSizeAndColor(forceToAdd);           

        }
    }  
    private Vector3 calculateForceToApply(Collision col)
    {
        // Calculate Angle Between the collision point and the cube and normilize it
        Vector3 dir = col.contacts[0].point - transform.position;
        dir = dir.normalized;

        // Calculate force of the collision 
        Vector3 force = col.impulse / Time.fixedDeltaTime;

        //Calculate force and direction to add taking into account dir, force and extraforce.
        //It must be negative to thow objetc in opossite direction.
        Vector3 forceCalculated = -(Vector3.Scale(dir, force) * extraForce);
        return forceCalculated;        
    }    
    private void reduceObjectSizeAndColor(Vector3 force)
    {           
        //On collision the object must reduce its size depending on the force applied
        Transform tran = GetComponent<Transform>();
        Renderer rend = GetComponent<Renderer>();
        Vector3 newSize = tran.localScale - (tran.localScale * force.magnitude / 800000);

        //Reduce till object size bigger than 2 and dissapear if smaller
        if (newSize.x > 2)
        {
            //Reduce size
            tran.localScale = newSize;

            //Reduce color
            rend.material.color = rend.material.color / tran.localScale.x;
            //Debug.Log("color: " + rend.material.color / tran.localScale.x);
        }
        else
        {
            //Destroy object 
            //rend.enabled = false;
            Destroy(gameObject);
        }
    }
}
