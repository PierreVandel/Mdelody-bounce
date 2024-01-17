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
        bool a = Input.GetKey(KeyCode.A);
        bool z = Input.GetKey(KeyCode.Z);
        bool e = Input.GetKey(KeyCode.E);
        bool r = Input.GetKey(KeyCode.R);
        bool t = Input.GetKey(KeyCode.T);
        bool y = Input.GetKey(KeyCode.Y);
        bool u = Input.GetKey(KeyCode.U);


        if (a)
            ID = 7 * BallCount++ + 0;
        else if (z)
            ID = 7 * BallCount++ + 1;
        else if (e)
            ID = 7 * BallCount++ + 2;
        else if (r)
            ID = 7 * BallCount++ + 3;
        else if (t)
            ID = 7 * BallCount++ + 4;
        else if (y)
            ID = 7 * BallCount++ + 5;
        else if (u)
            ID = 7 * BallCount++ + 6;
        else
            ID = BallCount++;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
