using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AmmoUIUpdater : MonoBehaviour
{
    public TextMeshProUGUI ammoText; // Reference to the UI Text element
    public ProjectileSpawner objectShooter; // Reference to the ObjectShooter script

    private void Start()
    {
        // Initialize the UI text with the maximum ammo value
        UpdateAmmoUI();
    }

    private void Update()
    {
        // Update the UI text with the current ammo value
        UpdateAmmoUI();
    }

    public void UpdateAmmoUI()
    {
        // Check if the references are valid
        if (ammoText != null && objectShooter != null)
        {
            // Update the UI Text with the current and maximum ammo values
            ammoText.text = "Ammo: " + objectShooter.currentAmmo + "/" + objectShooter.maxAmmo;
        }
    }
}
