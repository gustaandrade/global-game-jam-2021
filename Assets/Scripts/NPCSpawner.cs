using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCSpawner : MonoBehaviour
{
    public List<GameObject> npc;
    float randomX;
    public Vector2 whereToSpawn;
    public float spawnRate = 2f;
    float nextSpawn = 0f;
    int whatToSpawn;
    public bool twoNpcsInScene = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CountNPCs();
        if(Time.time > nextSpawn && !twoNpcsInScene)
        {
            whatToSpawn = Random.Range(0, npc.Count);     
            print(whatToSpawn);
            
            switch (whatToSpawn)
            {
                case 0:
                    Instantiate(npc[0], transform.position, Quaternion.identity);
                    break;
                case 1:
                    Instantiate(npc[1], transform.position, Quaternion.identity);
                    break;
                case 2:
                    Instantiate(npc[2], transform.position, Quaternion.identity);
                    break;
                case 3:
                    Instantiate(npc[3], transform.position, Quaternion.identity);
                    break;
                case 4:
                    Instantiate(npc[4], transform.position, Quaternion.identity);
                    break;
                case 5:
                    Instantiate(npc[5], transform.position, Quaternion.identity);
                    break;
                case 6:
                    Instantiate(npc[6], transform.position, Quaternion.identity);
                    break;
                case 7:
                    Instantiate(npc[7], transform.position, Quaternion.identity);
                    break;
                case 8:
                    Instantiate(npc[8], transform.position, Quaternion.identity);
                    break;
                case 9:
                    Instantiate(npc[9], transform.position, Quaternion.identity);
                    break;
                case 10:
                    Instantiate(npc[10], transform.position, Quaternion.identity);
                    break;
                case 11:
                    Instantiate(npc[11], transform.position, Quaternion.identity);
                    break;
                case 12:
                    Instantiate(npc[12], transform.position, Quaternion.identity);
                    break;
                case 13:
                    Instantiate(npc[13], transform.position, Quaternion.identity);
                    break;
                case 14:
                    Instantiate(npc[14], transform.position, Quaternion.identity);
                    break;
                case 15:
                    Instantiate(npc[15], transform.position, Quaternion.identity);
                    break;
            }
            nextSpawn = Time.time + spawnRate;
        }
    }

    void CountNPCs()
    {
        twoNpcsInScene = GameObject.FindGameObjectsWithTag("NPC").Length >= 1;
    }
}
