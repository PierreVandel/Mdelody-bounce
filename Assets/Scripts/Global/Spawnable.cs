using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnable : MonoBehaviour
{
    public GameObject[] ObjectsToSpawn;

    private List<GameObject> _Balls;

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
        _UpdateBalls();
        if (Input.GetMouseButtonDown(0))
        {
            _SpawnObject();
        }

        if (Input.GetKey(KeyCode.Backspace))
        {
            _ResetBalls();
        }
    }

    private void _SpawnObject()
    {
        Vector3 mousePosition = _GetMousePosition();
        
        if (_DetectBallOverlap(new Vector2(mousePosition.x, mousePosition.y)))
            return;

        Vector3 offset = new Vector3(0, 0, 10);

        bool touch1 = Input.GetKey(KeyCode.A);
        bool touch2 = Input.GetKey(KeyCode.Z);
        bool touch3 = Input.GetKey(KeyCode.E);
        bool touch4 = Input.GetKey(KeyCode.R);
        bool touch5 = Input.GetKey(KeyCode.T);
        bool touch6 = Input.GetKey(KeyCode.Y);
        bool touch7 = Input.GetKey(KeyCode.U);

        if (touch1)
            Instantiate(ObjectsToSpawn[0], mousePosition + offset, Quaternion.identity);
        else if (touch2)
            Instantiate(ObjectsToSpawn[1], mousePosition + offset, Quaternion.identity);
        else if (touch3)
            Instantiate(ObjectsToSpawn[2], mousePosition + offset, Quaternion.identity);
        else if (touch4)
            Instantiate(ObjectsToSpawn[3], mousePosition + offset, Quaternion.identity);
        else if (touch5)
            Instantiate(ObjectsToSpawn[4], mousePosition + offset, Quaternion.identity);
        else if (touch6)
            Instantiate(ObjectsToSpawn[5], mousePosition + offset, Quaternion.identity);
        else if (touch7)
            Instantiate(ObjectsToSpawn[6], mousePosition + offset, Quaternion.identity);
    }

    private Vector3 _GetMousePosition()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private void _ResetBalls()
    {
        AudioManager.Instance.StopSFX();

        for (int i = 0; i < _Balls.Count; i++)
        {
            GameObject ball = _Balls[i];

            Destroy(ball);
        }

        // Clear list after destroying all balls
        _Balls.Clear();
    }

    private void _UpdateBalls()
    {
        _Balls = new List<GameObject>();
        _Balls.AddRange(GameObject.FindGameObjectsWithTag("Ball"));
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
