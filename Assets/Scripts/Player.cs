using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float movementSpeed;
    private float score;

    private float rotationSpeed;
    private bool movingLeft;

    void Start()
    {
        score = 0;
        movingLeft = true;
    }

    void Update()
    {
        score += Time.deltaTime;
        transform.Translate(Vector3.down * Time.deltaTime * movementSpeed);

        if (Input.GetMouseButtonDown(0)) {
            rotationSpeed = 3;
            movingLeft = !movingLeft;
        }

        if (Input.GetMouseButton(0))
            rotationSpeed += 2 * Time.deltaTime;

        if (movingLeft)
            transform.Rotate(0, 0, rotationSpeed);
        else
            transform.Rotate(0, 0, -rotationSpeed);

        
    }

    void OnTriggerEnter(Collider other) {
        if (other.tag == "Obstacle")
            Die();
    }

    private void Die() {
        print("Player Dead");
        Destroy(this.gameObject);
    }
}
