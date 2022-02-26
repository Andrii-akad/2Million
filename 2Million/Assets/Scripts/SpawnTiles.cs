using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTiles : MonoBehaviour
{
    public GameObject tilePrefab;
    public GameObject fightPrefab;
    public GameObject eventPrefab;
    public GameObject parent;
    public const int stagesNumber = 9;
    // Start is called before the first frame update
    void Start()
    {
        spawnTiles();
    }
    private void spawnTiles()
    {
        Vector3 boundaries = parent.transform.GetComponent<SpriteRenderer>().bounds.size;
        for (int i = 0; i < stagesNumber; i++)
        {
            for (int j = 0; j < Random.Range(2, 5); j++)
            {
                GameObject tile = Instantiate(tilePrefab, new Vector3(-boundaries.x / 2 + (4 * j) + 4, boundaries.y / 2 - (3 * i) - 3, 0), Quaternion.identity);
                tile.transform.SetParent(parent.transform, false);

                Vector3 tileBoundaries = tile.transform.GetComponent<SpriteRenderer>().bounds.size;

                int eventR = Random.Range(0, 4);
                if (eventR == 1)
                {
                    GameObject _event = Instantiate(eventPrefab, new Vector3(-tileBoundaries.x / 2 + 2, tileBoundaries.y / 2-1, 0), Quaternion.identity);
                    _event.transform.SetParent(tile.transform, false);
                }
                else
                {
                    GameObject fight = Instantiate(fightPrefab, new Vector3((float)((float)-tileBoundaries.x / 2 + 0.5), tileBoundaries.y / 2 - 1, 0), Quaternion.identity);
                    fight.transform.SetParent(tile.transform, false);
                }

            }
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
