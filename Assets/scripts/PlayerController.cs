using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 10f;
    private float horizontalInput;
    private float xRange = 16;
    private float xRAnge = -16;
    
    public GameObject projectilePrefab;

  
    void Update()
    {
        // Movimiento horizontal de player
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);

        //limit de pantalla dreta
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        //limit pantalla esquerra 
        //if (transform.position.x < -xRange) manera simplificada sa multiplica per -1 sa variable
        if (transform.position.x < xRAnge)
        {
            transform.position = new Vector3(xRAnge, transform.position.y, transform.position.z);
        }

        //disparo
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
