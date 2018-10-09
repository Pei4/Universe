using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun : MonoBehaviour {
    public float y;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Transform transform = GetComponent<Transform>();
        /*Vector3 pos = transform.position;
        pos.x = pos.x + 0.02f;
        transform.position = pos;*/
        Vector3 angle = new Vector3(0, y*Time.deltaTime, 0);
        transform.Rotate(angle);
	}
}
