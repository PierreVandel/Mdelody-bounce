using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private bool _PauseActivated;

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        _PauseActivated = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            _PauseActivated = !_PauseActivated;
            PauseUnPause();
        }
    }

    public void PauseUnPause()
    {
        Time.timeScale = (_PauseActivated) ? 1.0f : 0.0f;
    }
}
