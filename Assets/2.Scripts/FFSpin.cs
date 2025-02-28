using DG.Tweening;
using UnityEngine;

public class FFSpin : MonoBehaviour
{
    Transform m_TransformBody;

    private void Start()
    {
        m_TransformBody = GetComponent<Transform>();
        
    }

    private void LateUpdate()
    {
        m_TransformBody.localEulerAngles = new Vector3(m_TransformBody.localEulerAngles.x, m_TransformBody.localEulerAngles.y + 1, m_TransformBody.localEulerAngles.z);
    }
}
