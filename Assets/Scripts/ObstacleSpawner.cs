using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject player;
    public GameObject obstacle;

    public int numberOfObstacles;
    public float minX, maxX;

    public void Start() {

        player = GameObject.FindWithTag("Player");

        for (int i = 0; i < numberOfObstacles; i++) {
            float xAxis = Random.Range(minX, maxX);
            float yAxis = Random.Range(player.transform.localPosition.y - 20, player.transform.localPosition.y - 50);

            Vector3 pos = new Vector3(xAxis, yAxis, 0);
            Instantiate(obstacle.transform, pos, Quaternion.identity);
        }
    }
}
