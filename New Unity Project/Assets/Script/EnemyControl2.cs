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
        lookAtLerp(player);
        MoveEnemy();
    }

    private void MoveEnemy()
    {
        Vector3 direction = player.transform.position-transform.position;
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
}
