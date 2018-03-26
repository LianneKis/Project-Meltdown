using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenade : Explosion {

    public float delay = 3f;

    float countdown;
    bool hasExploded = false;


	// Use this for initialization
	void Start () {
        countdown = delay;
	}
	
	// Update is called once per frame
	void Update () {
        countdown -= Time.deltaTime;
        if (countdown <= 0f && !hasExploded)
        {
            Explode();
            hasExploded = true;
        }
	}
}

