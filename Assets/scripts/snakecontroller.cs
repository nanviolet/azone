using UnityEngine;
using UnityEngine.UI;
public class snakecontroller : MonoBehaviour
{  
    public GameObject head;
    public GameObject body;
    public GameObject canvas;
    public float holder;
    private Vector3 forward = new Vector3(0, 0, 1);
    private Vector3 backward = new Vector3(0, 0, -1);
    private Vector3 right = new Vector3(1, 0, 0);
    private Vector3 left = new Vector3(-1, 0, 0);
    private Vector3 direction;
    private int length;
    private int scroe;
    private float time;
    
    // Start is called before the first frame update
    void Start()
    {
        
        time = 0;
        scroe = 0;
        length = 2;
        direction = forward;
        for(int i = 0; i < length; i++)
        {
            GameObject a = Instantiate(body, transform);
            body.transform.position = new Vector3(head.transform.position.x-0.1f, head.transform.position.y, head.transform.position.z-0.9f + (i - 1));
        }
    }

    // Update is called once per frame
    void Update()
    {
        canvas.transform.GetChild(1).GetComponent<Text>().text = "·ÖÊý:" + scroe;
        if (canvas.transform.GetChild(0).gameObject.activeSelf ==false)
        {
            if (Input.GetKeyDown(KeyCode.W) && !(head.transform.position.z < transform.GetChild(0).transform.position.z - 0.2f))
            {
                direction = forward;
            }
            else if (Input.GetKeyDown(KeyCode.S) && !(head.transform.position.z > transform.GetChild(0).transform.position.z))
            {
                direction = backward;
            }
            else if (Input.GetKeyDown(KeyCode.A))
            {
                if (!(head.transform.position.x > transform.GetChild(0).transform.position.x + 0.2f))
                    direction = left;
            }
            else if (Input.GetKeyDown(KeyCode.D) && !(head.transform.position.x < transform.GetChild(0).transform.position.x))
            {
                direction = right;
            }
            if (time > holder)
            {
                for (int i = length - 1; i > 0; i--)
                {
                    transform.GetChild(i).transform.position = transform.GetChild(i - 1).transform.position;
                }
                transform.GetChild(0).transform.position = new Vector3(head.transform.position.x - 0.1f, 0, head.transform.position.z + 0.1f);
                head.transform.position += direction;
                time = 0;
            }
            time += Time.deltaTime;
        }
        if (scroe >= 25)
        {
            canvas.transform.GetChild(0).gameObject.SetActive(true);
            canvas.transform.GetChild(4).gameObject.SetActive(true);
            canvas.transform.GetChild(5).gameObject.SetActive(true);
        }
    }
    public void Eat()
    {
        GameObject b = Instantiate(body, transform);
        b.transform.position = transform.GetChild(length - 1).position;
        length++;
        scroe++;
        if (holder > 0.15f)
        {
            holder -= 0.05f;
        }

    }

}

