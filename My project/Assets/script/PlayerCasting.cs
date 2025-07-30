using UnityEngine;

public class PlayerCasting : MonoBehaviour
{

    public static float distancefromtarget;
    [SerializeField] float toTarget;
    void Update()
    {
        RaycastHit Hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Hit))
        {
            toTarget = Hit.distance;
            distancefromtarget = toTarget;
        }
    }
}
