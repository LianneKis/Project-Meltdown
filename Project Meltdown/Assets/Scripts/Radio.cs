using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radio : MonoBehaviour
{

    public AudioSource radioSource;
    public bool isMuted = false;
    public AudioClip[] radioSongs;

    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    void Start()
    {
        radioSongs = Resources.LoadAll<AudioClip>("Music/Radio");
        radioSource = GetComponent<AudioSource>();
        radioSource.loop = false;

    }

    void Update()
    {
        if ((!radioSource.isPlaying)&&(isMuted == false))
        {
            radioSource.clip = radioSongs[Random.Range(0, radioSongs.Length)];
            radioSource.Play();
            isMuted = false;
        }
    }

    public void RadioPlayer(bool isMuted)
    {
        if (isMuted == true)
        {
            radioSource.Pause();
            isMuted = true;
        }

    }

    public void RadioChannel(string channelName)
    {
       

    }
}   