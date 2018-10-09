using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Earth : MonoBehaviour {
    public float self;
    public float around;
    private Sun SunPos;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Transform transform = GetComponent<Transform>();
        SunPos = GameObject.FindObjectOfType<Sun>();
        Vector3 angle = new Vector3(0, -self*Time.deltaTime, 0);
        Vector3 revolution = new Vector3(0, -around*Time.deltaTime,0);
        transform.Rotate(angle);
        transform.RotateAround(SunPos.transform.position,revolution,around);

    }
}
