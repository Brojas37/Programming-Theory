using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triangle : Shape
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = GenerateSpawnPos();
        Rotate(direction);
        pointsWorth = 25;
        speed = 10;
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        Move(speed);
    }

    public void Rotate(int side)
    {
        switch (side)
        {
            case 1:
                transform.Rotate(new Vector3(0, 180, 0), Space.World);
                break;
            case 2:
                transform.Rotate(new Vector3(0, -90, 0), Space.World);
                break;
            case 4:
                transform.Rotate(new Vector3(0, 90, 0), Space.World);
                break;
            default:
                break;
        }
    }

    public void OnMouseDown()
    {
        Clicked();
    }

    public override Vector3 GenerateSpawnPos()
    {
        Vector3 SpawnPos = new Vector3(0.0f, 0.0f, 0.0f);
        int side = Random.Range(1, 5);
        switch (side)
        {
            case 1:
                SpawnPos = new Vector3(-25.0f, -0.3f, Random.Range(-7.0f, 7.0f));
                break;
            case 2:
                SpawnPos = new Vector3(Random.Range(-17.0f, 17.0f), -0.3f, 15.0f);
                break;
            case 3:
                SpawnPos = new Vector3(25.0f, -0.3f, Random.Range(-7.0f, 7.0f));
                break;
            case 4:
                SpawnPos = new Vector3(Random.Range(-17.0f, 17.0f), -0.3f, -15.0f);
                break;
            default:
                Destroy(gameObject);
                break;
        }
        direction = side;
        return SpawnPos;
    }
}
