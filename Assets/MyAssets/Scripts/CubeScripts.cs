using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScripts : MonoBehaviour
{
    public float forceApplied = 50;

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
        // If the object we hit is the enemy
        if (col.gameObject.tag == "Player")
        {
            // Calculate Angle Between the collision point and the player
            Vector3 dir = col.contacts[0].point - transform.position;
            //col.

            // We then get the opposite (-Vector3) and normalize it
            dir = -dir.normalized;

            // And finally we add force in the direction of dir and multiply it by force. 
            // This will push back the player
            GetComponent<Rigidbody>().AddForce(dir * forceApplied);
        }
    }

}
