﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VRGaze : MonoBehaviour
{
    public Image imgGaze;
    public Text CubeMerah;
    public Text CubeHitam;
    public float totalTime = 2;
    bool gvrStatus, gvrStatus1;
    float gvrTimer;
 

    // Start is called before the first frame update
    void Start()
    {
       CubeMerah.enabled = false;
       CubeHitam.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (gvrStatus)
        {
            gvrTimer += Time.deltaTime;
            imgGaze.fillAmount = gvrTimer / totalTime;
        }
    }

    public void GVRON()
    {
        gvrStatus = true;
    }

    public void GVROff()
    {
        gvrStatus = false;
        gvrTimer = 0;
        imgGaze.fillAmount = 0;
    }

    public void CubeMerahOn(){
    	CubeMerah.enabled = true;
    }

    public void CubeMerahOff(){
    	CubeMerah.enabled = false;
    }

    public void CubeHitamOn(){
    	CubeHitam.enabled = true;
    }

    public void CubeHitamOff(){
    	CubeHitam.enabled = false;
    }
}