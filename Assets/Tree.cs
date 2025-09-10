using UnityEditor.ShaderGraph.Internal;
using UnityEngine;
using UnityEngine.WSA;

public class Tree : MonoBehaviour
{
    public GameObject LeafPrefab;
    public float spawnRateMin = 0.5f;
    public float spawnRateMax = 5f;


    private Transform target;
    private float spawnRate;
    private float timeAfterSpawn;
    void Start()
    {


        timeAfterSpawn = 0f;
        spawnRate = Random.Range(spawnRateMin, spawnRateMax);

        target = FindFirstObjectByType<PlayerController>().transform;
    }


    void Update()
    {

        timeAfterSpawn += Time.deltaTime;



        if(timeAfterSpawn >= spawnRate)
        {
            timeAfterSpawn = 0f;



            GameObject Leaf = Instantiate(LeafPrefab , transform.position, transform.rotation);

            Leaf.transform.LookAt(target);

            spawnRate = Random.Range(spawnRateMin, spawnRateMax);
        }
    }
}

