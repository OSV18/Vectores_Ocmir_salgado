using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl2 : MonoBehaviour
{
    [SerializeField] float SpeerEnemy = 10;

    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        lookPlayer();
        MoveEnemy();
    }

    private void MoveEnemy()
    {
        Vector3 direction = player.transform.position-transform.position;
        transform.Translate(SpeerEnemy * direction.normalized * Time.deltaTime);
    }

    private void lookPlayer()
    {
        Quaternion newRotation = Quaternion.LookRotation(player.transform.position - transform.position);
        transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, SpeerEnemy * Time.deltaTime);

    }
}
