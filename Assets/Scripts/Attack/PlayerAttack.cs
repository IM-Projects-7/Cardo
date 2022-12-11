using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject[] projectiles; // Liste des differents projectiles
    public float projectileSize = 0.05f; // Taille du projectile
    public float projectileYRange = 0.05f; // Intervalle de deplacement du projectile sur l'axe Y
    public int force = 10; // Facteur pour la vitesse
    public Color[] projectilesColors; // Liste de couleurs des projectiles
    public GameObject posRight;
    public GameObject posLeft;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            int noteType = Random.Range(0, projectiles.Length); // Genere aleatoirement un index pour determiner l'apparence du projectile
            GameObject noteProjectile = Instantiate(projectiles[noteType], Character.instance.isInRightOrientation()? posRight.transform.position: posLeft.transform.position, Quaternion.identity) as GameObject; // Cree un GameObject comme clone/instance du projectile selectionne 
            noteProjectile.tag = "Projectile";
            noteProjectile.transform.localScale = new Vector3(projectileSize, projectileSize, projectileSize); // Modifie sa taille en fonction de la variable projectileSize
            noteProjectile.transform.position = new Vector3(noteProjectile.transform.position.x, noteProjectile.transform.position.y + Random.Range(-projectileYRange, projectileYRange), noteProjectile.transform.position.z); // Modifie aleatoirement la position Y de l'instance
            noteProjectile.GetComponent<SpriteRenderer>().color = projectilesColors[Random.Range(0, projectilesColors.Length)]; // Modifie la couleur du sprite de l'instance par une des couleurs choisie aleatoirement
            noteProjectile.GetComponent<Rigidbody2D>().velocity = Character.instance.isInRightOrientation() ?  Vector2.right * force : Vector2.left * force; // Donne un mouvement vers la droite de l'axe X (direction du personnage) avec une vitesse par rapport a la variable force
            Destroy(noteProjectile, 2f);
            
        }
    }
}
