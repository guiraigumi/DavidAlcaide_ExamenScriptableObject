using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    
    public static InventoryManager Instance;

    public ScripteableObject[] weapons;
    public ScripteableObject[] armors;
    public Text[] weaponsNames;
    public Image[] weaponsSprites;
    public Text[] weaponsPrizes;
    public Text[] ArmorNames;
    public Image[] ArmorSprites;
    public Text[] ArmorPrizes;


    void Awake() 
    {
        Instance = this;
    }

    public void AddWeapon(ScripteableObject weapon)
    {
        for( int i = 0; i < weapons.Length; i++)
        {

            if(weapon.objectType == 0)
            {
                if(weapons[i] == null)
                {
                    weapons[i] = weapon;
                    weaponsNames[i].text = weapon.objectName;
                    weaponsSprites[i].sprite = weapon.objectSprite;
                    weaponsPrizes[i].text = weapon.objectPrize;

                    return;                
                }
            }
            if(weapon.objectType == 1)
            {
                if(armors[i] == null)
                {
                    armors[i] = weapon;
                    ArmorNames[i].text = weapon.objectName;
                    ArmorSprites[i].sprite = weapon.objectSprite;
                    ArmorPrizes[i].text = weapon.objectPrize;

                    return;                
                }
            }   

        }
    }

}
