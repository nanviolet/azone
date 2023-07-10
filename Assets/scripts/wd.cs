using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wd : MonoBehaviour
{
 

public class foodcontroller : MonoBehaviour
{
    public GameObject snake;
    public GameObject snakehead;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.name == "Head")
        {
            Debug.Log("1");
            snake.GetComponent<snakecontroller>().Eat();
            transform.position = new Vector3(Random.Range(0, 9) + 0.5f, 0f, Random.Range(0, 9) + 0.5f);

        }

    }
}

}
