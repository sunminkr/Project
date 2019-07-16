using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDrop : MonoBehaviour
{
    public GameObject Item;

    void Start()
    {
        InvokeRepeating("Spawnitem", 1, 10); //10초에 1번씩 Spawnitem()를 호출한다.
    }

    void Spawnitem()
    {
        float randomX = Random.Range(-23f, 19f);
        float randomZ = Random.Range(-23f, 19f);
        if (true)
        {
            //Debug.Log("생성");
            GameObject item = (GameObject)Instantiate(Item, new Vector3(randomX, 1.1f, randomZ), Quaternion.identity);
            Destroy(item, 10.0f);
        }
    }

}
