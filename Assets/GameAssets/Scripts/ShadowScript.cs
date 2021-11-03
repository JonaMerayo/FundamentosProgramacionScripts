using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class ShadowScript : MonoBehaviour
{
    public float movePower = 5; // The force added to the shadow to move it.
    public float maxVelocity = 25; // The maximum velocity the shadow can rotate at.
    public float movigTowardsPlayerSpeed = 1f;

    private Transform myTransform;
    private Transform playerTransform;
    private Vector3 aimedPosition;
    private Rigidbody m_Rigidbody;
    private Vector3 move;  // the world-relative desired move direction, calculated from the camForward and user input.

    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        myTransform = this.GetComponent<Transform>();

        // Get player transform
        playerTransform = GameObject.FindWithTag("Player").transform;

        // Set the maximum angular velocity.
        GetComponent<Rigidbody>().maxAngularVelocity = maxVelocity;        
    }
    // Update is called once per frame
    void Update()
    {
        // Get the axis input.
        float h = getCustomAxis("a", "d");
        float v = getCustomAxis("s", "w");

        // We move using world-relative directions
        move = (v * Vector3.forward + h * Vector3.right).normalized;
        
    }      
    private void FixedUpdate()
    {        
        // Call the Move function of the shadow controller
        Move(move);        

        //Set EthansPosition to go back
        aimedPosition = playerTransform.position;

        //Shadow has always Ethan Y-axis rotation
        myTransform.eulerAngles = new Vector3(180, playerTransform.eulerAngles.y+180, 0);
        //myTransform.LookAt(new Vector3(playerTransform.position.x, myTransform.position.y, playerTransform.position.z));

        //Shadow is always trying to came back to Ethan
        if (Vector3.Distance(myTransform.position, aimedPosition) >= 0.001f)
        {
            // Move our position a step closer to the target.
            float step = movigTowardsPlayerSpeed * Time.fixedTime; // calculate distance to move
            myTransform.position = Vector3.MoveTowards(m_Rigidbody.position, aimedPosition, step);

        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Laser"))
        {
            this.gameObject.SetActive(false);
            if (GameObject.FindWithTag("LevelFloor") != null)
            {
                GameObject.FindWithTag("LevelFloor").SetActive(false);
            }
        }
    }

    public void Move(Vector3 moveDirection)
    {
        // Add force in the move direction.
        m_Rigidbody.AddForce(moveDirection * movePower);
    }

    private float getCustomAxis(string negativeVector, string positiveVector)
    {
        if (Input.GetKey(negativeVector))
        {
            return -1f;
        }

        else if (Input.GetKey(positiveVector))
        {
            return 1f;
        }

        else
        {
            return 0;
        }
    }
}
