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
    
    // Instanciation d'un objet vide cube, qui deviendra le cube survolé par la souris
    GameObject selectedCube = null;

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
        // A chaque frame, on vérifie si le clic droit est activé, et si oui on supprime notre objet.
        if(Input.GetMouseButtonUp(1)) 
        {
            Destroy(selectedCube);
        }
    }

    private void OnMouseOver() 
    {
        // Lorsque je survole un cube, je l'assigne à ma variable
        selectedCube = this.gameObject;
        mat.color = overColor;
    }

// Lorsqu'on ne survole plus l'élément
    private void OnMouseExit() 
    {
        mat.color = baseColor;

        // Lorsque je ne survole plus, je remet la variable à null pour éviter de stocker de nombreux cubes
        selectedCube = null;   
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
