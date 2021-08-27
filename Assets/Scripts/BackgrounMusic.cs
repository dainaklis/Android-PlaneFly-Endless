using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgrounMusic : MonoBehaviour
{   
    private static BackgrounMusic backgroundMusic;

    private void Awake() 
    {
        if (backgroundMusic == null)
        {
            backgroundMusic = this;
            DontDestroyOnLoad(backgroundMusic);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
