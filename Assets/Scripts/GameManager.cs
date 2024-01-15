using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    {

    }
    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            Debug.Log("Mettre en pause le jeu");
        }
        if (Input.GetKeyDown("m"))
        {
            Debug.Log("Afficher Map");
        }
    }
}
