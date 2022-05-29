using UnityEngine;

public class Hero : MonoBehaviour, IDamageable
{
    public void ApplyDamage(int countDamage)
    {
        Debug.Log("Hero");
    }
}
