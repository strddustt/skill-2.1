using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class mapparabola : MonoBehaviour
{
    [SerializeField] private int totalPoints;
    [SerializeField] private double a;
    [SerializeField] private double b;
    [SerializeField] private double c;
    [SerializeField] private GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        MapParabola(totalPoints, a, b, c);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void MapParabola(int totalPoints, double a, double b, double c)
    {
        float step = 0.2f;

        // Find vertex of the parabola
        double xVertex = -b / (2 * a);

        // Start x value to make the curve centered on the vertex
        double startX = xVertex - (totalPoints / 2) * step;

        for (int i = 0; i <= totalPoints; i++)
        {
            double x = startX + i * step;
            double y = a * x * x + b * x + c;

            Vector3 position = new Vector3((float)x, (float)y, 0f);
            Instantiate(prefab, position, Quaternion.identity);
        }
    }
}
