using EmeraldAI;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Collider c;
    private bool randomBool;

    [Header("Stats du joueur:")]
    [Tooltip("Damage du player (PV)")]
    public int Damage;
    [Tooltip("% de chance de faire un coup critique (%)")]
    public int LuckCriticalHit;
    private void OnTriggerEnter(Collider other)
    {
        c = other;
    }
    void Update()
    {
        if (c != null)
        {
            if (Input.GetMouseButtonDown(0) && (Vector3.Distance(transform.position, c.transform.position) <= 2.6))
            {
                if (Random.Range(1, 100) <= LuckCriticalHit)
                {
                    randomBool = true;
                }
                else
                {
                    randomBool = false;
                }
                c.GetComponent<EmeraldAISystem>().Damage(Damage, null, transform, 100, randomBool);
            }
        }
    }
}
