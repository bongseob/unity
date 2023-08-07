using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGenerator : MonoBehaviour
{
    public GameObject pipe;

    [SerializeField]
    private float timeDiff = 0.5f;

    float timer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > timeDiff)
        {
            GameObject newPipe = Instantiate(pipe, transform.position, Quaternion.identity);
            newPipe.transform.position = new Vector3(5f, Random.Range(-1.9f, 4.2f), 0f);
            timer = 0f;
            Destroy(newPipe, 8.0f);
        }
        
    }

}
