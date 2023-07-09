using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tuto : MonoBehaviour
{
    public GameObject cubeObj;
    public Color couleur2;

    // Start is called before the first frame update
    void Start()
    {
        // cubeObj will appear on 0,0,0 with his default rotation
        
        for (int i = 0; i < 10; i++) 
        {
            for (int j = 0; j < 10; j++) 
            {
                // On stocke chaque GameObject (cube) dans une variable "go"
                GameObject go = Instantiate(cubeObj, new Vector3(i,0,j), Quaternion.identity);
                if ((j % 2) == 0 && (i % 2) == 0) 
                {
                    // On accède au composant MeshRenderer afin de modifier ses propriétés
                    go.GetComponent<MeshRenderer>().material.color =  couleur2;
                    go.transform.position += new Vector3(0,1,0);
                }
            }
           
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
