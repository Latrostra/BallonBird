using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField]
    private Vector3 position;
    private ObjectPooler objectPooler;
    [SerializeField]
    private bool random = false;

    private void Awake() {
        objectPooler = GetComponent<ObjectPooler>();
        StartCoroutine("SpawnObstacle");
    }
    // Spawn Obstacle at fixed position
    public IEnumerator SpawnObstacle() {
        while (true) {
            if (objectPooler.GetObstacle() != null)
            {
                var obj = objectPooler.GetObstacle();
                SetFixedPosition(obj);
                obj.transform.localScale = new Vector3(Random.Range(1f, 1.5f), Random.Range(0.7f, 1.5f), 1);
                obj.SetActive(true);
            }
            yield return new WaitForSeconds(3f);
        }
    }

    // Set fixed position
    private void SetFixedPosition(GameObject obj)
    {
        if (random)
        {
            obj.transform.position = new Vector3(10, Random.Range(-5f, 5f), 0);
        }
        else
        {
            obj.transform.position = new Vector3(10, -5.6f, 0);
        }
    }
}
