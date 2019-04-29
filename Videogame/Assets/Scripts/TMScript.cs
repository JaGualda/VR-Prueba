﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class TMScript : MonoBehaviour
{
	public GameObject activate;
	public Interactable door;
    public Transform player;
    
	
	private bool puzzle;
    private Vector3 position;
    // Start is called before the first frame update
    void Start()
    {
		door.enabled = false;
		door.enabled = false;
        GetComponent<TextMesh>().text="";
		puzzle = true;
        //position = Transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (player.position.z <= 14)
            transform.position = new Vector3(200, 200, 200);
        else
            transform.position = position;
		if (activate.transform.position.y < -1.0f){
			if (puzzle){
				if (GetComponent<TextMesh>().text.Length == 4 && GetComponent<TextMesh>().text != "" && GetComponent<TextMesh>().text != "1826"){
					if(GetComponent<TextMesh>().text.Length == 4 && GetComponent<TextMesh>().text == "4129")
						Debug.Log("Que listillo tu, ¿No?");
					Debug.Log("Fallo");
					GetComponent<TextMesh>().text="Error";
					//sleep a second
					GetComponent<TextMesh>().text="";
				}
				else if(GetComponent<TextMesh>().text.Length == 4 && GetComponent<TextMesh>().text == "1826"){
					Debug.Log("Acierto");
					GetComponent<TextMesh>().text="Open";
					puzzle = false;
					door.enabled = true;
				}
			}
			else
				GetComponent<TextMesh>().text="Open";
		}
		else
				GetComponent<TextMesh>().text=" ";
    }
}
