using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anicube : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Return))
        {
            GetComponent<Animator>().SetBool("isJump", true);
            GetComponent<Animator>().applyRootMotion = false;
        }
	}

    void Land()
    {
        GetComponent<Animator>().SetBool("isJump", false);
        GetComponent<Animator>().applyRootMotion = true;

    }
}
