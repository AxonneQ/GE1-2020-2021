using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public int rings = 10;
    public GameObject prefab;
    List<GameObject> shapes = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        int elements = 0;

        for (int i = 1; i < rings + 1; i++)
        {
            elements += 6;
            float theta = Mathf.PI * 2.0f / (float)elements;
            for (int j = 0; j < elements; j++)
            {
                GameObject sp = GameObject.Instantiate<GameObject>(prefab);
                Vector3 pos = new Vector3(Mathf.Sin(theta * j) * i, 1, Mathf.Cos(theta * j) * i);
                sp.transform.position = transform.TransformPoint(pos);
                sp.transform.Rotate(0, theta * Time.deltaTime, 0);
                shapes.Add(sp);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        foreach (GameObject s in shapes)
        {
            s.transform.Rotate(0, 50 * Time.deltaTime, 0);

        }


    }
}
