using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] float SpeedPlayer = 10f;
    float cameraAxis;
    private Vector3 initScale = new Vector3(1f,1f,1f);
    [SerializeField] GameObject[] SpawnWall;
    //private bool isPass = false;
    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = initScale;
    }

    // Update is called once per frame
    void Update()
    {
        RotationPlayer();
        MovePlayer();

    }

    private void MovePlayer()
    {
        float ejeHorizontal = Input.GetAxisRaw("Horizontal");
        float ejeVertical = Input.GetAxisRaw("Vertical");
        transform.Translate(SpeedPlayer * Time.deltaTime * new Vector3(ejeHorizontal, 0, ejeVertical));

    }

    private void RotationPlayer()
    {
        cameraAxis += Input.GetAxis("Mouse X");
        Quaternion angle = Quaternion.Euler(0, cameraAxis, 0);
        transform.localRotation = angle;

    }

    private float timmer;
    private void OnCollisionStay(Collision collision)
    {

        if (collision.gameObject.CompareTag("Wall"))
        {

            Debug.Log(collision.gameObject.name);
            timmer += Time.deltaTime;
            if (timmer >= 2)
            {
                collision.gameObject.transform.position = SpawnWall[Random.Range(0, SpawnWall.Length)].transform.position;
                collision.gameObject.transform.rotation = SpawnWall[Random.Range(0, SpawnWall.Length)].transform.rotation;

                timmer = 0;
            }
        }
    }
    
    private float timmerS;
    /*
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Portal"))
        {
            transform.localScale = initScale;
        }

    }
    */
    private void OnTriggerExit(Collider other)
    {
        Debug.Log(other.gameObject.name);
        if (other.gameObject.CompareTag("Portal"))
        {
            transform.localScale = initScale;
          
        }
     
    }
    private void OnTriggerStay(Collider other)
    {
        Debug.Log(other.gameObject.name);
        if (other.gameObject.CompareTag("Portal"))
        {
            transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        }
    }


}

