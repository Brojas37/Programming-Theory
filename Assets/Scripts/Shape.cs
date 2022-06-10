using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    public int direction;
    public float pointsWorth;
    public float speed;
    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual Vector3 GenerateSpawnPos()
    {
        Vector3 SpawnPos = new Vector3(0.0f, 0.0f, 0.0f);
        int side = Random.Range(1, 5);
        switch (side)
        {
            case 1:
                SpawnPos = new Vector3(-25.0f, 0.0f, Random.Range(-7.0f, 7.0f));
                break;
            case 2:
                SpawnPos = new Vector3(Random.Range(-17.0f, 17.0f), 0.0f, 15.0f);
                break;
            case 3:
                SpawnPos = new Vector3(25.0f, 0.0f, Random.Range(-7.0f, 7.0f));
                break;
            case 4:
                SpawnPos = new Vector3(Random.Range(-17.0f, 17.0f), 0.0f, -15.0f);
                break;
            default:
                Destroy(gameObject);
                break;
        }
        direction = side;
        return SpawnPos;
    }

    public virtual void Move(float speed)
    {
        switch (direction)
        {
            case 1:
                transform.position += new Vector3(speed, 0.0f, 0.0f) * Time.deltaTime;
                if (transform.position.x > 25)
                {
                    Destroy(gameObject);
                }
                break;
            case 2:
                transform.position += new Vector3(0.0f, 0.0f, -speed) * Time.deltaTime;
                if (transform.position.z < -15)
                {
                    Destroy(gameObject);
                }
                break;
            case 3:
                transform.position += new Vector3(-speed, 0.0f, 0.0f) * Time.deltaTime;
                if (transform.position.x < -25)
                {
                    Destroy(gameObject);
                }
                break;
            case 4:
                transform.position += new Vector3(0.0f, 0.0f, speed) * Time.deltaTime;
                if (transform.position.z > 15)
                {
                    Destroy(gameObject);
                }
                break;
            default:
                Destroy(gameObject);
                break;
        }
    }

    public void Clicked()
    {
        gameManager.AddToScore(pointsWorth);
        Destroy(gameObject);
    }
}
