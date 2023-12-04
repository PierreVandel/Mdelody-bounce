using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;
    public Sound[] SfxSounds;
    public AudioSource SfxSrc;

    public void Awake()
    {
        Instance = this;
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
        Sound s = System.Array.Find(SfxSounds, e => e.Name == Name);

        if (s == null)
        {
            Debug.Log("No sfx found.");
        }
        else
        {
            SfxSrc.PlayOneShot(s.Clip);
        }
    }
}
