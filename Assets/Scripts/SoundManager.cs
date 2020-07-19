using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public AudioClip[] clips=new AudioClip[3];
    public AudioSource audioSource;

    public Toggle[] toggles = new Toggle[3];
    
    public void PlaySound()
    {
        List<int> activeToggles=new List<int>();
        for(int i=0;i<toggles.Length;i++)
        {
            if(toggles[i].isOn)
            {
                activeToggles.Add(i);
            }
        }

        if(activeToggles.Count>0)
        {
            int clipNumberToPlay = activeToggles[Random.Range(0, activeToggles.Count)];
            audioSource.PlayOneShot(clips[clipNumberToPlay]);
        }
        

    }
}
