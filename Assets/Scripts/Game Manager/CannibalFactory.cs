using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Generic enemy factory. Can be set with any type of enemy prefab and will work to spawn that type.
public class EnemyFactory : MonoBehaviour
{
    private GameObject enemyPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void spawnNewCannibal(Transform spawnPoint)
    {
        Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);
    }

    public void setPrefab(GameObject prefab)
    {
        this.enemyPrefab = prefab;
    }
}
