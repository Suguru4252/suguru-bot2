using UnityEngine;

public class ModelLoader : MonoBehaviour
{
    public string modelPath = "Models/Character"; // Resources-папка
    public Transform cameraTarget;

    void Start()
    {
        GameObject model = Resources.Load<GameObject>(modelPath);
        if (model != null)
        {
            GameObject instance = Instantiate(model, Vector3.zero, Quaternion.identity);
            if (cameraTarget != null)
                cameraTarget.position = instance.transform.position;
        }
    }
}