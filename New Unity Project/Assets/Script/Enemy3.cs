using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3 : MonoBehaviour
{
    [SerializeField] float SpeerEnemy = 6f;
    private float newSpeedEnemy = 3f;
    private GameObject player;
    private enum EnemyType { Feral, Walker, Calm}
    [SerializeField] private EnemyType enemyType;
    private int zoobieType;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        lookAtLerp(player);
        SetDificultiType(enemyType);
        //MoveEnemy();
    }

    private void MoveEnemy()
    {
        Vector3 direction = player.transform.position - transform.position;
        if (direction.magnitude > 2)
        {
            transform.position += SpeerEnemy * direction.normalized * Time.deltaTime;
        }

    }

    private void lookAtLerp(GameObject lookObject)
    {
        Vector3 direction = lookObject.transform.position - transform.position;
        Quaternion newQuaternion = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Lerp(transform.rotation, newQuaternion, 5f * Time.deltaTime);

    }

    private void SetDificultiType(EnemyType enemyType)
    {
        switch (enemyType)
        {
            case EnemyType.Calm:
                Calm();
                break;
            case EnemyType.Walker:
                Walker();
                break;
            case EnemyType.Feral:
                Feral();
                break;

        }

    }

    private void Calm()
    {
        Vector3 direction = player.transform.position - transform.position;
        if (direction.magnitude > 2)
        {
            transform.position += (SpeerEnemy -6f) * direction.normalized * Time.deltaTime;
        }
    }
    private void Walker()
    {
        Vector3 direction = player.transform.position - transform.position;
        if (direction.magnitude > 2)
        {
            transform.position += (SpeerEnemy - 3f) * direction.normalized * Time.deltaTime;
        }
    }
    private void Feral()
    {
        Vector3 direction = player.transform.position - transform.position;
        if (direction.magnitude > 2)
        {
            transform.position += SpeerEnemy * direction.normalized * Time.deltaTime;
        }
    }

}
