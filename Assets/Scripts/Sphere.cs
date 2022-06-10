using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape
{
    public float timer = 0.0f;
    public float curveValue;
    public float curveSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        transform.position = GenerateSpawnPos();
        pointsWorth = 15;
        speed = 6;
        curveValue = 4;
        curveSpeed = 4;
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        Move(speed);
        timer += Time.deltaTime * curveSpeed;
    }

    public void OnMouseDown()
    {
        Clicked();
    }

    public override void Move (float speed)
    {
        switch (direction)
        {
            case 1:
                transform.position += new Vector3(speed, 0.0f, 0.0f + (Mathf.Sin(timer) * curveValue)) * Time.deltaTime;
                if (transform.position.x > 25)
                {
                    Destroy(gameObject);
                }
                break;
            case 2:
                transform.position += new Vector3(0.0f + (Mathf.Sin(timer) * curveValue), 0.0f, -speed) * Time.deltaTime;
                if (transform.position.z < -15)
                {
                    Destroy(gameObject);
                }
                break;
            case 3:
                transform.position += new Vector3(-speed, 0.0f, 0.0f + (Mathf.Sin(timer) * curveValue)) * Time.deltaTime;
                if (transform.position.x < -25)
                {
                    Destroy(gameObject);
                }
                break;
            case 4:
                transform.position += new Vector3(0.0f + (Mathf.Sin(timer) * curveValue), 0.0f, speed) * Time.deltaTime;
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
}
