using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnPool : MonoBehaviour
{
    public float ypositionmin = -1f;
    public float ypositionmax = 3.5f;
    public float spawnrate = 4f;    
    public int columnPoolSize = 5;
    private GameObject[] colums;
    public GameObject columnPref;
    public Vector2 objectpools = new Vector2(-15f, -25f);
    private float timeSinceSpawned;
    private float spawnXposition = 10f;
    private int currentcolumn = 0;
    // Start is called before the first frame update
    void Start()
    {
        colums = new GameObject[columnPoolSize];
        for (int i = 0; i < columnPoolSize; i++)
        {
            colums[i] = (GameObject)Instantiate(columnPref, objectpools, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceSpawned += Time.deltaTime;
        if (GameControl.instance.gameOver==false && timeSinceSpawned >= spawnrate)
        {
            timeSinceSpawned = 0;
            float spawnYposition = Random.Range(ypositionmin, ypositionmax);
            colums[currentcolumn].transform.position = new Vector2(spawnXposition, spawnYposition);
            currentcolumn++;
            if (currentcolumn >= columnPoolSize)
            {
                currentcolumn = 0;
            }
        }
    }
}
