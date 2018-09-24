using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundScript : MonoBehaviour {

    public AudioClip MusicClip;
    public AudioClip MusicClip2;
    public AudioSource MusicSource;
    public AudioSource MusicSource2;

    // Use this for initialization
    void Start () {
        MusicSource.clip = MusicClip;
        MusicSource2.clip = MusicClip2;
        MusicSource.Play();
        MusicSource2.Play();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
