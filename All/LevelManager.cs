using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject treeGroup;
    private int treeSpawnNum = 5;

    // Called on first frame
    void Start()
    {
        for (int i = 0; i < treeSpawnNum; i++)
        {
            GameObject temp = Instantiate(gameObject, gameObject.transform.position + new Vector3(Random.Range(0, 10), 0, Random.Range(0, 10)), Quaternion.identity);
        }
    }

    void Update()
    {

    }
}
