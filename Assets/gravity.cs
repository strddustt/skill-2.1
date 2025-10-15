using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class gravity : MonoBehaviour
{
    //d(t) = v * t
    private double g = -9.82; //gravity
    private double x;
    private double? startX = null;
    private Vector2 d = new Vector2(5, 1);
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            jump();
        }
        x = transform.position.x;
        if (startX != null)
        {
            double? newX = x - startX;
            //function:
            double? y = 0.5 * g * (newX * newX) +1.2257;
            Vector2 position = new Vector2((float)newX, (float)y);
            startX = null;
        }
    }
    private void jump()
    {
        startX = x;
        

    }
}
