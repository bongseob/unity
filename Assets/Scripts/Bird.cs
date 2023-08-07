using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bird : MonoBehaviour
{
    Rigidbody2D rb;

    [SerializeField] 
    private float jumpPower = 3f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            rb.velocity = Vector2.up * jumpPower;
        }       
    }

    private void OnCollisionEnter2D(Collision2D other) {
        Debug.Log($"OnCollisionEnter2D:{other.gameObject.name}");
        SceneManager.LoadScene("GameOverScene");
    }
}