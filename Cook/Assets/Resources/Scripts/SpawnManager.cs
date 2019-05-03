using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour {
    //public GameObject[] enemies;
    float cd;
    float lastSpawn;
    public int level;
    float minCd;
    float maxCd;
   public float spawnRateDivision;
    private GameObject[] EnemyPrefabs;
    private int dice, lane;
    // Use this for initialization
     void Awake()
     {
         EnemyPrefabs = new GameObject[3];

         EnemyPrefabs[0] = Resources.Load<GameObject>("Prefabs/Alien_Baloon");
         EnemyPrefabs[1] = Resources.Load<GameObject>("Prefabs/Alien_Bird");
         EnemyPrefabs[2] = Resources.Load<GameObject>("Prefabs/Alien_Octopus");
     }
    void Start () {
        lastSpawn = Time.time;
        cd = 3;
        minCd = 1;
        maxCd = 6;
        spawnRateDivision = 0.1f;
        level = 1;

        StartCoroutine(Spawn());
    }
	
	



    IEnumerator Spawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(cd);

            dice = Random.Range(0,3);
			lane = Random.Range(0,3);

            Vector3 screen = new Vector3(Screen.width, Screen.height / 6 + (lane) * Screen.height / 3, 10);
            Vector3 position = UnityEngine.Camera.main.ScreenToWorldPoint(screen);

            int RandomIndex;
            if (level == 1)
            {

               
                if (lastSpawn + cd < Time.time)
                {
                    ////Spawn First
                    cd = EnemyPrefabs[0].gameObject.GetComponent<Enemy>().health / 100f / (spawnRateDivision * level);
                    lastSpawn = Time.time;
                    Debug.Log("Enemy " + 1 + " Spawned on "+ (lane+1)+". Lane");
                     Instantiate(EnemyPrefabs[dice], position, Quaternion.identity);
                }

            }

            else if (level == 2)
            {
                RandomIndex = Random.Range(0, 30);

                if (RandomIndex < 20 && lastSpawn + cd < Time.time)
                {
                    ////Spawn First
                    cd = EnemyPrefabs[0].gameObject.GetComponent<Enemy>().health / 100f / (spawnRateDivision * level);
                    lastSpawn = Time.time;
                    Debug.Log("Enemy " + 1 + " Spawned on " + (lane + 1) + ". Lane");
                     Instantiate(EnemyPrefabs[dice], position, Quaternion.identity);
                }
                else if (lastSpawn + cd < Time.time)
                {
                    ////Spawn Second
                    cd = EnemyPrefabs[1].gameObject.GetComponent<Enemy>().health / 100f / (spawnRateDivision * level);
                    lastSpawn = Time.time;
                    Debug.Log("Enemy " + 2 + " Spawned on " + (lane + 1) + ". Lane");
                    Instantiate(EnemyPrefabs[dice], position, Quaternion.identity);
                }

            }
            else
            {
                RandomIndex = Random.Range(0, 60);

                if (RandomIndex < 20 && lastSpawn + cd < Time.time)
                {
                    ////Spawn First
                    cd = EnemyPrefabs[0].gameObject.GetComponent<Enemy>().health / 100f / (spawnRateDivision * level);
                    lastSpawn = Time.time;
                    Debug.Log("Enemy " + 1 + " Spawned on " + (lane + 1) + ". Lane");
                    Instantiate(EnemyPrefabs[dice], position, Quaternion.identity);
                }
                else if (RandomIndex < 40 && lastSpawn + cd < Time.time)
                {
                    ////Spawn Second
                    cd = EnemyPrefabs[1].gameObject.GetComponent<Enemy>().health / 100f / (spawnRateDivision * level);
                    lastSpawn = Time.time;
                    Debug.Log("Enemy " + 2 + " Spawned on " + (lane + 1) + ". Lane");
                    Instantiate(EnemyPrefabs[dice], position, Quaternion.identity);
                }
                else if (lastSpawn + cd < Time.time)
                {
                    ////Spawn Third
                    cd = EnemyPrefabs[2].gameObject.GetComponent<Enemy>().health / 100f / (spawnRateDivision * level);
                    lastSpawn = Time.time;
                    Debug.Log("Enemy " + 3 + " Spawned on " + (lane + 1) + ". Lane");
                    Instantiate(EnemyPrefabs[dice], position, Quaternion.identity);
                }

            }
        }
        

        
    }
    
}
