using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallID : MonoBehaviour
{
    public static int BallCount = 0;
    public int ID = 0;
    

    // Start is called before the first frame update
    void Start()
    {
        ID = BallCount;
        BallCount++;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
