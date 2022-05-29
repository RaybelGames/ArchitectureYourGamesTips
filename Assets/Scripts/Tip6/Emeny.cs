using UnityEngine;

public class Emeny : MonoBehaviour, IDamageable
{
    public void ApplyDamage(int countDamage)
    {
        Debug.Log("Emeny");
    }
}
