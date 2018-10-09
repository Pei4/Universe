using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moon : MonoBehaviour {
    public float y;
    public float around;
    private Earth EarthPos;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Transform transform = GetComponent<Transform>();
        EarthPos = GameObject.FindObjectOfType<Earth>();
        Vector3 angle = new Vector3(0, y*Time.deltaTime, 0);
        Vector3 revolution = new Vector3(0, around * Time.deltaTime, 0);
        transform.Rotate(angle);
        transform.RotateAround(EarthPos.transform.position, revolution, around);
    }
}
