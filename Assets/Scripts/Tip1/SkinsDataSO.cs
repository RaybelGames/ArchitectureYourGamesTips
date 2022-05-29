using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SkinsDataSO", menuName = "Data/SkinsDataSO")]
public class SkinsDataSO : ScriptableObject
{
    public List<SkinData> skinData = new List<SkinData>();
}
