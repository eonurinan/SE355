using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [System.NonSerialized] public static bool spawn = true;
    [SerializeField] float minSpawnDelay, maxSpawnDelay;
    private GameObject[] EnemyPrefabs;
    private int dice, lane;

    void Awake()
    {
        EnemyPrefabs = new GameObject[3];

        EnemyPrefabs[0] = Resources.Load<GameObject>("Prefabs/Alien_Baloon");
        EnemyPrefabs[1] = Resources.Load<GameObject>("Prefabs/Alien_Bird");
        EnemyPrefabs[2] = Resources.Load<GameObject>("Prefabs/Alien_Octopus");
    }

    IEnumerator Start()
    {
        minSpawnDelay = RemoteConfig.minSpawnDelay;
        maxSpawnDelay = RemoteConfig.maxSpawnDelay;
        while (spawn)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnDelay, maxSpawnDelay));
            dice = Random.Range(0, 3);
            lane = Random.Range(0, 3);

            Vector3 screen = new Vector3(Screen.width, Screen.height / 6 + (lane) * Screen.height / 3, 10);
            Vector3 position = UnityEngine.Camera.main.ScreenToWorldPoint(screen);

            Instantiate(EnemyPrefabs[dice], position, Quaternion.identity);
        }
    }
}