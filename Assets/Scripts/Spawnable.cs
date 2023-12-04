using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnable : MonoBehaviour
{
    public GameObject ObjectToSpawn;

    private GameObject[] _Balls;

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
            _UpdateBalls();
            _SpawnObject();
        }
    }

    private void _SpawnObject()
    {
        Vector3 mousePosition = _GetMousePosition();
        
        if (_DetectBallOverlap(new Vector2(mousePosition.x, mousePosition.y)))
            return;

        Vector3 offset = new Vector3(0, 0, 10);

        Instantiate(ObjectToSpawn, mousePosition + offset, Quaternion.identity);
    }

    private Vector3 _GetMousePosition()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private void _UpdateBalls()
    {
        _Balls = GameObject.FindGameObjectsWithTag("Ball");
    }

    private bool _DetectBallOverlap(Vector2 Pos)
    {
        foreach (GameObject ball in _Balls)
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
