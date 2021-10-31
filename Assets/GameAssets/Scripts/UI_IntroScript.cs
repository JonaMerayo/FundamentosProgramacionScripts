using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.ThirdPerson;

public class UI_IntroScript : MonoBehaviour
{
    private Button normalBtn;
    private Button turboBtn; 
    private ThirdPersonCharacter thirdPersonChar; // A reference to the ThirdPersonCharacter on the object
    private LaserScript laserScr;
    private GameObject picksErasables;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;//Pause the game 

        normalBtn = GameObject.Find("ButtonNormal").GetComponent<Button>();
        normalBtn.onClick.AddListener(onClickNormal);
        
        turboBtn = GameObject.Find("ButtonTurbo").GetComponent<Button>();
        turboBtn.onClick.AddListener(onClickTurbo);

        thirdPersonChar = GameObject.Find("Ethan").GetComponent<ThirdPersonCharacter>();

        laserScr = GameObject.FindGameObjectWithTag("Laser").GetComponent<LaserScript>();

        picksErasables = GameObject.Find("PickUpsErasables");
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void onClickNormal()
    {
        thirdPersonChar.m_MoveSpeedMultiplier = 1f; //Ethan speed restored.
        picksErasables.SetActive(true);//But eliminates some pickUps from scene.
        Time.timeScale = 1;//Resume game
        this.gameObject.SetActive(false);
    }
    private void onClickTurbo()
    {
        thirdPersonChar.m_MoveSpeedMultiplier=1.5f; //Ethan speed increased.
        picksErasables.SetActive(false);//But eliminates some pickUps from scene.
        Time.timeScale = 1;//Resume game
        this.gameObject.SetActive(false);
    }

}
