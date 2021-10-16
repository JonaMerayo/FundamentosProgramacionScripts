using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderScript : MonoBehaviour
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

    /*****************************************************************************/
    private float speed = 2f;

    //Moves this GameObject 2 units a second in the forward direction
    //void Update()
    //{
    //    transform.Translate(Vector3.forward * Time.deltaTime * speed);
    //}

    //Upon collision with another GameObject, this GameObject will reverse direction
    private void OnTriggerEnter(Collider other)
    {
        speed = speed * -1;
    }
    /****************************************************************************/
    void OnCollisionEnter(Collision col)
    {
        // If the object that hit it is the Player
        if (col.gameObject.tag == "Player")
        {
            // Calculate Angle Between the collision point and the player
            Vector3 dir = col.contacts[0].point - transform.position;

            // We then get the opposite (-Vector3) and normalize it
            dir = -dir.normalized;

            // And finally we add force in the direction of dir and multiply it by force. 
            // This will push back the cylinder
            GetComponent<Rigidbody>().AddForce(dir * forceApplied);
        }
    }
}
