using UnityEngine;

public class Wall : MonoBehaviour, IDamageable
{
    public void ApplyDamage(int countDamage)
    {
        Debug.Log("Wall");
    }
}
