using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerfollow : MonoBehaviour
{
    public GameObject player;
    public float smooth;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void LateUpdate()
    {
        if (player != null) { 
       
            if (player.transform.position != transform.position) { 
             Vector3 a=player.transform.position;
                transform.position = Vector3.Lerp(transform.position, a, smooth);
            }
        
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
