using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformScript : MonoBehaviour
{

    public GameObject sobstaclePrefab;
    public GameObject mobstaclePrefab;
    public GameObject lobstaclePrefab;
    GameObject[] platformCell = new GameObject[10];
    GameObject[] obstacleCell = new GameObject[3];
    public GameObject[] platformPrefabVar = new GameObject[4];    


    void Start()
    {
        /*Camera cam = Camera.main;
        float height = 2f * cam.orthographicSize;
        float width = height * cam.aspect;
        Debug.Log(height);
        Debug.Log(width);*/

        //Vector3 screenPos = Camera.main.WorldToScreenPoint(this.transform.position);
        //Debug.Log(screenPos.x);
        //private SpriteRenderer spriteRenderer;
        //RectTransform rt;
        float j = 0;
        for (int i = 0; i < 10; i++)
        {
            platformCell[i] = Instantiate(platformPrefabVar[Random.Range(0, 4)], new Vector3(j, 0, 0), Quaternion.identity) as GameObject;
            //RectTransform rt = (RectTransform)platformCell[i].transform;
            //float width = GetComponent<SpriteRenderer>().bounds.size.x;
            j = j + 4f;
           // float tileWidth = (float)tileSet[0].renderer.bounds.size.x;
            //Vector3 objectSize = Vector3.Scale(transform.localScale, GetComponent().mesh.bounds.size);
            //Debug.Log(objectSize);
        }

        obstacleCell[0] = Instantiate(sobstaclePrefab, new Vector3(Random.Range(0, 10.0f), 1.5f, 0), Quaternion.identity) as GameObject;
        obstacleCell[1] = Instantiate(mobstaclePrefab, new Vector3(Random.Range(0, 10.0f), 1.5f, 0), Quaternion.identity) as GameObject;
        obstacleCell[2] = Instantiate(lobstaclePrefab, new Vector3(Random.Range(0, 10.0f), 1.5f, 0), Quaternion.identity) as GameObject;
        //k = k + 2f;

    }

    void FixedUpdate()
    {
        int count = 0;
        for (int i = 0; i < 10; i++)
        {
            if (platformCell[i] != null)
            {

                platformCell[i].transform.Translate(5 * Vector3.left * Time.deltaTime);
                if (platformCell[i].transform.position.x < -12f)
                {
                    Vector3 temp = new Vector3(24f, 0, 0);
                    //platformCell[i].transform.position += temp;
                    Destroy(platformCell[i].gameObject);//resetposition instead of destroy??
                    //platformCell[i] = Instantiate(platformPrefabVar[Random.Range(0, 3)], temp, Quaternion.identity) as GameObject;
                    count++;
                    Debug.Log(count);
                    while(count==1)
                    {
                        platformCell[i] = Instantiate(platformPrefabVar[Random.Range(0, 4)], temp, Quaternion.identity) as GameObject;
                        count--;
                    }

                }
            }
        }

        obstacleCell[0].transform.Translate(5 * Vector3.left * Time.deltaTime);
        obstacleCell[1].transform.Translate(5 * Vector3.left * Time.deltaTime);
        obstacleCell[2].transform.Translate(5 * Vector3.left * Time.deltaTime);

    }
}
