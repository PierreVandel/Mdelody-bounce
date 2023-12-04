using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    public Sound[] sfxSounds;
    public AudioSource sfxSrc;

    public void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlaySFX(string Name)
    {
        Sound s = System.Array.Find(sfxSounds, e => e.Name == Name);

        if (s == null)
        {
            Debug.Log("No sfx found.");
        }
        else
        {
            sfxSrc.PlayOneShot(s.Clip);
        }
    }
}
