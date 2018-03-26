using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {


    public int vitality = 100;
    public int currentVitality;
    bool passedOut;
    bool isRecovering;
    bool damaged;
    bool isDead;

    public AudioClip passingoutClip;
    public AudioClip hurtClip;
    public AudioClip deathClip;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        // If the player has just been damaged...
        if (damaged)
        {

        }

        if (passedOut)
        {

        }

        if (isDead)
        {

        }

    }
}
