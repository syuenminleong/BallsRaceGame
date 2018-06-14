﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{

	private Transform pT;
	private Vector3 offset;
	private Vector3 moveV;
	
	// Use this for initialization
	void Start ()
	{
		//Find players object based on tag
		pT = GameObject.FindGameObjectWithTag("Player").transform;
		
		//Create offset
		offset = transform.position - pT.position;
	}
	
	// Update is called once per frame
	void Update ()
	{
		moveCamera();
	}

	void moveCamera()
	{
		
		//Find player's position 
		moveV = pT.position + offset;
		
		//if (pT.position.z + offset.z = moveV.z)
		//{
			//Fix camera movements
			moveV.x = 3.5f;
			//moveV.y = Mathf.Clamp(moveV.y, 3, 5); 
		
			//Move camera
			transform.position = moveV;
		//}
	}
}