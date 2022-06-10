using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = GenerateSpawnPos();
        pointsWorth = 5;
        speed = 3;
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        Move(speed);
    }

    public void OnMouseDown()
    {
        Clicked();
    }
}
