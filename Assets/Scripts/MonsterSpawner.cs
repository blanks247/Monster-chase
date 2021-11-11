using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] monsterReference;

    private GameObject spawnedMonster;

    [SerializeField]
    private Transform leftpos, rightpos;

    private int randomIndex;
    private int randomside;


    void Start()
    {
        StartCoroutine(SpawnMonsters());
    }
    IEnumerator SpawnMonsters() {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(1, 5));

            randomIndex = Random.Range(0, monsterReference.Length);
            randomside = Random.Range(0, 2);

            spawnedMonster = Instantiate(monsterReference[randomIndex]);

            if (randomside == 0)
            {
                spawnedMonster.transform.position = rightpos.position;
                spawnedMonster.GetComponent<Monster>().speed = -Random.Range(4, 10);
                spawnedMonster.transform.localScale = new Vector3(-1f, 1f, 1f);
            }

            else
            {
                spawnedMonster.transform.position = leftpos.position;
                spawnedMonster.GetComponent<Monster>().speed = Random.Range(4, 10);
                
            }

        }
    }

}
