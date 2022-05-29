using UnityEngine;

public class ShopSkinsOld : MonoBehaviour
{
    public int id;
    public string nameSkin;
    public int price;
    public Color color;
    public TypeSkin typeSkin;

    public enum TypeSkin
    {
        Weapon,
        Hero
    };

    private void GetShopItem(int id)
    {
        //return shop item
    }

    private void BuyShopItem(int id)
    {
        //buy shop item
    }
}


