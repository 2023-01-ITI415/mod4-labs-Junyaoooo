using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour
{
    public GameObject m_Player;
    public Vector3 offset;
    private float _pointY;
    public float damping = 1;
    void Start()
    {
        offset = transform.position - m_Player.transform.position;
    }

    void Update()
    {

        _pointY = m_Player.transform.eulerAngles.y;
        Quaternion rotatiom = Quaternion.Euler(0, _pointY, 0);
        transform.position = Vector3.Lerp(transform.position, m_Player.transform.position + (rotatiom * offset), Time.deltaTime * damping);
        transform.LookAt(m_Player.transform.position);

    }
    void LookAt()
    {
        var dir = (m_Player.transform.position - transform.position).normalized;
        var quat = Quaternion.LookRotation(dir);
        transform.rotation = quat;
    }

}




