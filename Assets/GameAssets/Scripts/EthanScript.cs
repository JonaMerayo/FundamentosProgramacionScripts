using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityStandardAssets.Characters.ThirdPerson;

public class EthanScript : MonoBehaviour
{
    public delegate void PickedCoin();
    public event PickedCoin OnPickCoin;

    private ThirdPersonCharacter m_Character; // A reference to the ThirdPersonCharacter on the object
    private Transform m_Cam;                  // A reference to the main camera in the scenes transform
    private Vector3 m_CamForward;             // The current forward direction of the camera
    private Vector3 m_Move;
    private bool m_Jump;                      // the world-relative desired move direction, calculated from the camForward and user input.
    private Transform myTransform;
    private GameObject gameOverUI;
    private GameObject youWinUI;


    private void Start()
    {
        // get the transform of the main camera
        if (Camera.main != null)
        {
            m_Cam = Camera.main.transform;
        }
        else
        {
            Debug.LogWarning(
                "Warning: no main camera found. Third person character needs a Camera tagged \"MainCamera\", for camera-relative controls.", gameObject);
            // we use self-relative controls in this case, which probably isn't what the user wants, but hey, we warned them!
        }

        // get the third person character ( this should never be null due to require component )
        m_Character = GetComponent<ThirdPersonCharacter>();

        myTransform = GetComponent<Transform>();

        gameOverUI = GameObject.Find("GameOverCanvas");
        gameOverUI.SetActive(false);

        youWinUI = GameObject.Find("YouWinCanvas");
        youWinUI.SetActive(false);
    }


    private void Update()
    {
        if (!m_Jump)
        {
            m_Jump = Input.GetKeyDown("space");
        }
    }


    // Fixed update is called in sync with physics
    private void FixedUpdate()
    {
        // read inputs
        float h = getCustomAxis("left", "right");
        float v = getCustomAxis("down", "up");
        bool crouch = Input.GetKey(KeyCode.C);

        // calculate move direction to pass to character
        if (m_Cam != null)
        {
            // calculate camera relative direction to move:
            m_CamForward = Vector3.Scale(m_Cam.forward, new Vector3(1, 0, 1)).normalized;
            m_Move = v * m_CamForward + h * m_Cam.right;
        }
        else
        {
            // we use world-relative directions in the case of no main camera
            m_Move = v * Vector3.forward + h * Vector3.right;
        }
#if !MOBILE_INPUT
        // walk speed multiplier
        if (Input.GetKey(KeyCode.LeftShift)) m_Move *= 0.5f;
#endif

        // pass all parameters to the character control script
        m_Character.Move(m_Move, crouch, m_Jump);
        m_Jump = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);

            if (OnPickCoin != null)
                OnPickCoin(); //Activates delegated method
        }
            
        if (other.gameObject.CompareTag("LowerLimit"))
        {
            Time.timeScale = 0; //Pause the game
            //And.. Game OVER
            gameOverUI.SetActive(true);
        }
            
        if (other.gameObject.CompareTag("Portal"))
        {
            //Debug.Log("You Win!");
            myTransform.position = new Vector3(0, 57, 50);
            Camera.main.transform.position = new Vector3(0, 67, 30);
            youWinUI.SetActive(true);
            //Invoke(Time.timeScale = 0, 3);
        }

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

