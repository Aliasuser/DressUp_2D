using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomerAudioScript : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip[] audioClips;

    public void OnImage()
    {
        audioSource.PlayOneShot(
            audioClips[Random.Range(0, audioClips.Length)]);
    }

    public void StopSound()
    {
        audioSource.Stop();
    }
}
