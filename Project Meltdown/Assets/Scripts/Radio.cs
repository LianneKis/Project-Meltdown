using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radio : MonoBehaviour
{

    public AudioSource audioSource;
    public bool isOn = true;
    public AudioClip[] clips;

    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    // Use this for initialization
    void Start()
    {
        clips = Resources.LoadAll<AudioClip>("Music");
        audioSource = GetComponent<AudioSource>();
        audioSource.loop = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (isOn == false)
        {

        }
        if (!audioSource.isPlaying)
        {
            audioSource.clip = clips[Random.Range(0, clips.Length)];
            audioSource.Play();
        }
    }
}   