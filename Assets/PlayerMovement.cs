using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public Vector3 movement;
    public GameObject myobject;

	// Use this for initialization
	void Start () {
        

	}
	
	// Update is called once per frame
	void Update () {
        transform.position += movement;
    }
}
