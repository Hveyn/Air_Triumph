using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private GameObject[] Targets;
    //[SerializeField] private float WaitTime = 1f;
    [SerializeField] private float EnemySpeed = 3f;
  
    private Transform SpawnerPosition;
    
    private Coroutine corutine;


    private void Awake()
    {
        SpawnerPosition = GetComponent<Transform>();
        corutine =  StartCoroutine(CoroutineSample());
    }

    private IEnumerator CoroutineSample()
    {
        GameObject enemy = Instantiate(enemyPrefab, SpawnerPosition.position, SpawnerPosition.rotation);
        foreach (GameObject t in Targets)
        {
            yield return StartCoroutine(Utils.MoveToTarget(enemy.transform, t.transform.position, EnemySpeed));
        }
        Destroy(enemy);
        if(enemy == null)
        {
            StopCoroutine(corutine);
        }
    }
}
