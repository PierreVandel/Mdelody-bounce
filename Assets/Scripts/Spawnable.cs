using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnable : MonoBehaviour
{
    public GameObject spawnObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Spawn onclick
        if (Input.GetMouseButtonDown(0))
        {
            SpawnObject();
        }
    }

    void SpawnObject()
    {
        Vector3 pos = GetMousePosition();
        Vector3 offset = new Vector3(0, 0, 10);

        Instantiate(spawnObject, pos + offset, Quaternion.identity);
    }

    private Vector3 GetMousePosition()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}
