using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip planeMotor, planeDead;
    static AudioSource audioSrc;
    void Start()
    {
        planeMotor = Resources.Load<AudioClip>("heli");
        planeDead = Resources.Load<AudioClip>("sfx14");

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "heli":
                audioSrc.PlayOneShot(planeMotor);
                break;
            case "sfx14":
                audioSrc.PlayOneShot(planeDead);
                break;
            
        }
    }
}
