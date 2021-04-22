using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitcher : MonoBehaviour
{
    public int selectedWeapon = 0;
    // Start is called before the first frame update
    void Start()
    {
        SelectWeapon();
    }

    // Update is called once per frame
    void Update()
    {
        int previousSelectedWeapon = selectedWeapon;
        if (Input.GetKeyDown(KeyCode.Alpha1)) // States that if the Input is left click it will fire an arrow.
        {
            selectedWeapon = 0;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2)) // States that if the Input is left click it will fire an arrow.
        {
            selectedWeapon = 1;
        }
        if (previousSelectedWeapon != selectedWeapon)
        {
            SelectWeapon();
        }
    }
    void SelectWeapon()
    {
        int i = 0;
        foreach(Transform weapon in transform)
        {
            if (i == selectedWeapon)
                weapon.gameObject.SetActive(true);
            else
                weapon.gameObject.SetActive(false);
            i++;
        }
    }
}