using UnityEngine;
using UnityEngine.Events;

public class ShopSkinsNew : MonoBehaviour
{
    [Header("Static Data")]
    public SkinsDataSO skinsDataSO;

    private SkinData GetShopItem(int id)
    {
        var temp = skinsDataSO.skinData[id];

        if (temp != null)
            return skinsDataSO.skinData[id];
        else
            return null;
    }

    private void BuyShopItem()
    {
        //buy shop item
    }
}
