using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Target : MonoBehaviour
{
    public Transform cameraTransform;
    public TextMeshProUGUI scoreText;
    private int score = 0;

    private void OnCollisionEnter(Collision collision)
    {
        score += (int)(Vector3.Distance(cameraTransform.position, transform.position)*10);
        scoreText.text = $"Score: {score}";
    }
}
