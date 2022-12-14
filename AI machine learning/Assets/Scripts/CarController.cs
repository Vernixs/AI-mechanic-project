using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    private Vector3 startPosition, startRotation;

    [Range(-1, 1f)]
    public float a, t;

    public float timeSinceStart = 0f;

    [Header("Fitness")]
    public float overallFitness;
    public float distanceMultiplier = 1.4f;
    public float avgSpeedMultiplier = 0.2f;

    private Vector3 lastPosition;
    private float totalDistanceTravelled;
    private float avgSpeed;

    private float aSensor, bSensor, cSensor;

    private void Awake()
    {
        startPosition = transform.position;
        startRotation = transform.eulerAngles;

    }


    public void Reset()
    {
        timeSinceStart = 0f;
        totalDistanceTravelled = 0f;
        avgSpeed = 0f;
        lastPosition = startPosition;
        overallFitness = 0f;
        transform.position = startPosition;
        transform.eulerAngles = startRotation;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Reset();
    }

    private Vector3 inp;
    public void MoveCar (float v, float h)
    {
        inp = Vector3.Lerp(Vector3.zero, new Vector3(0, 0, v * 11.4f), 0.02f);
        inp = transform.TransformDirection(inp);

    }
}
