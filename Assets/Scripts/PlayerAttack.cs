using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject slashPrefab; // Assign the Slash GameObject
    public float slashDuration = 0.2f;
    private bool isAttacking = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J) && !isAttacking)
        {
            StartCoroutine(Slash());
        }
    }

    private System.Collections.IEnumerator Slash()
    {
        isAttacking = true;
        slashPrefab.SetActive(true);
        yield return new WaitForSeconds(slashDuration);
        slashPrefab.SetActive(false);
        isAttacking = false;
    }
}
