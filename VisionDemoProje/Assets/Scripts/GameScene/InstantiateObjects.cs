using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateObjects : MonoBehaviour
{
    public GameObject obje;
    
    public float objectZ = 100;
    public float beetwenTime = 3;

    private int startWait;

    public bool stop;

    private Vector3 objectPosition;
    public List<GameObject> objects = new List<GameObject>();

    private Camera mainCam;

    // Start is called before the first frame update
    void Start()
    {
        mainCam = Camera.main;
        StartCoroutine(InstantiateObject());
    }

    // Update is called once per frame
    void Update()
    {
        objectPosition = new Vector3(Random.Range(-4f, 4f), 1, transform.position.z + objectZ);
        
    }

    private IEnumerator InstantiateObject()
    {
        
        yield return new WaitForSeconds(startWait);

        while (!stop)
        {
            GameObject cube = Instantiate(obje, objectPosition, Quaternion.identity);
            
            yield return new WaitForSeconds(beetwenTime);
        }
    }

    
}
