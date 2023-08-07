using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime; //(-1,0,0)

    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Bird"){
            Debug.Log("Bird");
            GameManager.instance.IncreaseScore();
        }
    }
}
