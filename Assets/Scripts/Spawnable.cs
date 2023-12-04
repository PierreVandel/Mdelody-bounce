using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnable : MonoBehaviour
{
    public GameObject spawnObject;

    private GameObject[] Balls;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        SpawnOnClick();
    }

    public void SpawnOnClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            UpdateBalls();
            SpawnObject();
        }
    }

    private void SpawnObject()
    {
        Vector3 mousePosition = GetMousePosition();
        
        if (DetectBallOverlap(new Vector2(mousePosition.x, mousePosition.y)))
            return;

        Vector3 offset = new Vector3(0, 0, 10);

        Instantiate(spawnObject, mousePosition + offset, Quaternion.identity);
    }

    private Vector3 GetMousePosition()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private void UpdateBalls()
    {
        Balls = GameObject.FindGameObjectsWithTag("Ball");
    }

    private bool DetectBallOverlap(Vector2 Pos)
    {
        foreach (GameObject ball in Balls)
        {
            Collider2D c = ball.GetComponent<CircleCollider2D>();
            if (c.OverlapPoint(Pos))
            {
                Debug.Log("Ball hit");
                return true;
            }
        }

        return false;
    }
}
