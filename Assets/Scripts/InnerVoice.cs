using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InnerVoice : MonoBehaviour {

    public AudioClip startGame;
    public AudioClip goodLandingArea;

    private AudioSource audioSource;

	void Start () {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = startGame;
        audioSource.Play();
	}
	
    void OnFindClearArea()
    {
        print(name + "Found ClearArea");
        audioSource.clip = goodLandingArea;
        audioSource.Play();

        Invoke("CallHeli", goodLandingArea.length + 1f);
    }

    void CallHeli()
    {
        SendMessageUpwards("OnMakeInitialHeliCall");
    }

}
