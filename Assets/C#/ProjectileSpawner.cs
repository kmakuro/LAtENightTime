using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ProjectileSpawner : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Transform launchPoint; // The point from which the projectile is launched
    public float shotDelay = 1.0f; // Delay between shots in seconds
    public int maxAmmo = 5; // Maximum ammunition
    public int currentAmmo; // Current ammunition
    
    public KeyCode reloadKey = KeyCode.R;
    public AmmoUIUpdater ammoUIUpdater;
    private float lastShotTime;
    
    void Start()
    {
        currentAmmo = maxAmmo;
    }

    private void Update()
    {
        // Check for mouse click to shoot
        if (Input.GetMouseButtonDown(0) && currentAmmo > 0 && Time.time - lastShotTime >= shotDelay)
        {
            Shoot();
            lastShotTime = Time.time;
        }

// Check for reload key press
        if (Input.GetKeyDown(reloadKey))
        {
            Reload();
        }

        void Shoot()
        {
            // Create an instance of the projectile at the launch point
            GameObject newProjectile = Instantiate(projectilePrefab, launchPoint.position, launchPoint.rotation);

            // Add force to the projectile to make it move forward
            Rigidbody rb = newProjectile.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddForce(transform.forward * 10f, ForceMode.Impulse); // Adjust the force as needed
            }

            // Decrease the current ammo count
            currentAmmo--;

            // If the ammo is depleted, you can add logic to handle it (e.g., disable shooting)
            if (currentAmmo <= 0)
            {
                currentAmmo = 0;
                // Optionally, you can disable shooting or perform other actions when ammo is depleted.
            }
        }

        void Reload()
        {
            if (currentAmmo == maxAmmo)
            {
                return; // No need to reload if already at max ammo
            }

            // Calculate the number of bullets to add during the reload
            int bulletsToAdd = maxAmmo - currentAmmo;

            // Perform the reload by adding bullets
            currentAmmo += bulletsToAdd;

            // Update the UI through the reference to AmmoUIUpdater
            ammoUIUpdater.UpdateAmmoUI();

        }
    }
}



