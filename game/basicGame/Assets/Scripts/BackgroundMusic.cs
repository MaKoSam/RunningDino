using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    private static BackgroundMusic backgroundMusic;

    private void Awake()
    {
        if (backgroundMusic != null && backgroundMusic != this)
        {
            Destroy(this.gameObject);
            return;
        }

        backgroundMusic = this;
        DontDestroyOnLoad(this);
    }
}
