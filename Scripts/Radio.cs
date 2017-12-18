using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radio : MonoBehaviour {

    public AudioClip initialHeliCall;
    public AudioClip initialCallReply;

    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();

    }

    void OnMakeInitialHeliCall()
    {
        audioSource.clip = initialHeliCall;
        audioSource.Play();

        Invoke("Reply", initialHeliCall.length);
    }

    void Reply()
    {
        audioSource.clip = initialCallReply;
        audioSource.Play();

        BroadcastMessage("OnCallHelicopter");
    }

}
