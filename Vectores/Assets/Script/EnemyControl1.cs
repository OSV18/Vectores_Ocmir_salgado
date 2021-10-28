using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl1 : MonoBehaviour
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

    }

    private void lookPlayer()
    {
        Quaternion newRotation = Quaternion.LookRotation(player.transform.position - transform.position);
        transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, SpeerEnemy * Time.deltaTime);

    }
}

