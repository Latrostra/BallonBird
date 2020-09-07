using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{
    [SerializeField]
    private int amount = 5;
    [SerializeField]
    private GameObject prefab;
    List<GameObject> obstacles;

    private void Awake() {
        obstacles = new List<GameObject>();
        for (int i = 0; i < amount; i++) {
            var obj = Instantiate(prefab, transform.position, Quaternion.identity);
            obstacles.Add(obj);
            obj.SetActive(false);
        }
    }

    public GameObject GetObstacle() {
        foreach (GameObject obstacle in obstacles) {
            if (obstacle.activeSelf == false) {
                return obstacle;
            }
        }
        return null;
    }
}
