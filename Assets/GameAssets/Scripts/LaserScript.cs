using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserScript : MonoBehaviour
{
    public float movingSpeed = 1f;
    public float distanceRepeled = 2f;
    public EthanScript ethanEvents;

    private Transform myTransform;
    private Vector3 aimedPosition;
    private bool floorYetDestroyed = false;

    // Start is called before the first frame update
    void Start()
    {
        myTransform = this.GetComponent<Transform>();

        //Set original position based on parent´s position (center of lasers)
        aimedPosition = GameObject.FindWithTag("LasersCenter").transform.position ;

        // We recover player delegated events script
        ethanEvents = GameObject.FindWithTag("Player").GetComponent<EthanScript>();
        ethanEvents.OnPickCoin += repelLasers;
    }

   // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(myTransform.position, aimedPosition) >= 0.001f)
        {
            // Move our position a step closer to the target.
            float step = movingSpeed * Time.deltaTime; // calculate distance to move
            myTransform.position = Vector3.MoveTowards(transform.position, aimedPosition, step);

        }
        else if (floorYetDestroyed==false) //If they reach center and floor hasn't been destroyed yet, do it now and finish the game
        {
            if (GameObject.FindWithTag("LevelFloor") != null)
            {
                GameObject.FindWithTag("LevelFloor").SetActive(false);
            }
            
            floorYetDestroyed = true;
        }
    }

    void OnDisable()
    {
        ethanEvents.OnPickCoin -= repelLasers;
    }

    void repelLasers()
    {
        //Debug.Log("laser detected");
        myTransform.position = Vector3.MoveTowards(transform.position, aimedPosition, -distanceRepeled);
    }

}
