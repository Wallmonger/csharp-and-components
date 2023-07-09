using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    public Color baseColor;
    public Color overColor;
    Material mat;

    // Instanciation d'un objet vide cube, dont on renseignera l'objet directement dans unity
    public GameObject cube;

    // Start is called before the first frame update
    void Start()
    {
        // Au début du script, j'initialise mon material en récupérant celui du cube
        mat = GetComponent<MeshRenderer>().material;
        baseColor = mat.color;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseOver() 
    {
        mat.color = overColor;
    }

// Lorsqu'on ne survole plus l'élément
    private void OnMouseExit() 
    {
        mat.color = baseColor;   
    }


// Lors du clic de la souris
    private void OnMouseUp() 
    {
        // On créer une variable pos, qui est égale à la position Vector3 de l'objet cliqué (x,y,z) au niveau supérieur
        Vector3 pos = this.transform.position + Vector3.up;

        // Ensuite, on instancie un nouveau gameObject avec les paramètres de position, en conservant sa rotation
        GameObject go = Instantiate(cube, pos, Quaternion.identity);
        go.GetComponent<MeshRenderer>().material.color = new Color(0.1f,0.5f,0.1f);
    }
}
