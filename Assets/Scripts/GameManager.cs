using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float score;
    public GameUI gameUI;
    public GameObject Cube;
    public GameObject Sphere;
    public GameObject Triangle;

    private float cubeTimer;
    private float cubeWait;
    private float sphereTimer;
    private float sphereWait;
    private float triTimer;
    private float triWait;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        gameUI = GameObject.Find("Canvas").GetComponent<GameUI>();
        gameUI.StartGame();
        cubeTimer = 0.0f;
        cubeWait = 2;
        sphereTimer = 0.0f;
        sphereWait = 4;
        triTimer = 0.0f;
        triWait = 6;
    }

    // Update is called once per frame
    void Update()
    {
        CheckCube();
        if (cubeWait <= 1)
        {
            CheckSphere();
            if (sphereWait <= 2)
            {
                CheckTri();
            }
        }
    }

    public void AddToScore(float points)
    {
        score += points;
        gameUI.UpdateYourScore();
    }

    public void CreateCube()
    {
        Instantiate(Cube);
    }

    public void CreateSphere()
    {
        Instantiate(Sphere);
    }

    public void CreateTri()
    {
        Instantiate(Triangle, Triangle.transform.position, Triangle.transform.rotation);
    }

    public void CheckCube()
    {
        cubeTimer += Time.deltaTime;
        if (cubeTimer > cubeWait)
        {
            if (cubeWait > 1)
            {
                cubeWait -= 0.1f;
            }
            cubeTimer = 0;
            CreateCube();
        }
    }

    public void CheckSphere()
    {
        sphereTimer += Time.deltaTime;
        if (sphereTimer > sphereWait)
        {
            if (sphereWait > 1)
            {
                sphereWait -= 0.25f;
            }
            sphereTimer = 0;
            CreateSphere();
        }
    }

    public void CheckTri()
    {
        triTimer += Time.deltaTime;
        if (triTimer > triWait)
        {
            if (triWait > 1)
            {
                triWait -= 0.5f;
            }
            triTimer = 0;
            CreateTri();
        }
    }
}
