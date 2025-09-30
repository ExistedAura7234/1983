using UnityEngine;

public class WeaponBase : MonoBehaviour
{
    public string weaponName = "Pistol";
    public float damage = 10f;
    public float fireRate = 1f;
    public float accuracy = 0.9f;

    public virtual void Fire()
    {
        // Implementa disparo básico
        Debug.Log("Disparo de " + weaponName);
    }

    public void ModifyParameters(float newDamage, float newFireRate, float newAccuracy)
    {
        damage = newDamage;
        fireRate = newFireRate;
        accuracy = newAccuracy;
    }
}