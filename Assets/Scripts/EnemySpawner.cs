using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

    public GameObject enemy;
    public Vector3 centerFront;
    public Vector3 sizeFront;
    public Vector3 centerBack;
    public Vector3 sizeBack;
    public Vector3 centerLeft;
    public Vector3 sizeLeft;
    public Vector3 centerRight;
    public Vector3 sizeRight;

    private Variables var;

    // Use this for initialization
    void Start () {
        var = GameObject.Find("Variables").GetComponent<Variables>();


        for (int i = 0; i <= var.booty; i += 1000)
        {
            if (i <= 3000)
            {
                SpawnEnemyFront();
            }

            if (i <= 6000 && i > 3000)
            {
                SpawnEnemyLeft();
            }

            if (i <= 9000 && i > 6000)
            {
                SpawnEnemyRight();
            }

            if (i <= 12000 && i > 9000)
            {
                SpawnEnemyBack();
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SpawnEnemyFront()
    {
        Vector3 pos = centerFront + new Vector3(Random.Range(-sizeFront.x / 2, sizeFront.x / 2), Random.Range(-sizeFront.y / 2, sizeFront.y / 2), Random.Range(-sizeFront.z / 2, sizeFront.z / 2));
        Instantiate(enemy, pos, Quaternion.identity);

    }

    public void SpawnEnemyLeft()
    {
        Vector3 pos = centerLeft + new Vector3(Random.Range(-sizeLeft.x / 2, sizeLeft.x / 2), Random.Range(-sizeLeft.y / 2, sizeLeft.y / 2), Random.Range(-sizeLeft.z / 2, sizeLeft.z / 2));
        Instantiate(enemy, pos, Quaternion.identity);
    }

    public void SpawnEnemyRight()
    {
        Vector3 pos = centerRight + new Vector3(Random.Range(-sizeRight.x / 2, sizeRight.x / 2), Random.Range(-sizeRight.y / 2, sizeRight.y / 2), Random.Range(-sizeRight.z / 2, sizeRight.z / 2));
        Instantiate(enemy, pos, Quaternion.identity);
    }

    public void SpawnEnemyBack()
    {
        Vector3 pos = centerBack + new Vector3(Random.Range(-sizeBack.x / 2, sizeBack.x / 2), Random.Range(-sizeBack.y / 2, sizeBack.y / 2), Random.Range(-sizeBack.z / 2, sizeBack.z / 2));
        Instantiate(enemy, pos, Quaternion.identity);
    }

    private void OnDrawGizmosSelected()
    {
        //Front Spawn
        Gizmos.color = new Color(1, 0, 0, 5f);
        Gizmos.DrawCube(centerFront, sizeFront);

        //Back Spawn
        Gizmos.DrawCube(centerBack, sizeBack);

        //left Spawn
        Gizmos.DrawCube(centerLeft, sizeLeft);

        //Right Spawn
        Gizmos.DrawCube(centerRight, sizeRight);
    }
}
