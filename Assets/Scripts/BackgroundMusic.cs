using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    // Creating a singleton
    private static BackgroundMusic Instance { get; set; } = null;

    private void Awake()
    {
        // Checking if there is already an instance of this class
        if (Instance != null && Instance != this)
        {
            // Destroying this object
            Destroy(this.gameObject);
            return;
        }
        else
        {
            // Setting the instance
            Instance = this;
        }
        // Making this object persistent
        DontDestroyOnLoad(this.gameObject);
    }
}
