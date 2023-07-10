using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class boom : MonoBehaviour
{
    public GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "head")
        {
            canvas.transform.GetChild(3).gameObject.SetActive(true);
            canvas.transform.GetChild(0).gameObject.SetActive(true);
            canvas.transform.GetChild(5).gameObject.SetActive(true);
        }
    }
}
