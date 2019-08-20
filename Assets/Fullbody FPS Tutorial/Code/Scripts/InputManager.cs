using UnityEngine;

public class InputManager : MonoBehaviour
{
    #region Variables
    [Header("Movement Axis")]
    [SerializeField]
    private string m_forwardAxis = "Vertical";
    [SerializeField]
    private string m_sidewayAxis = "Horizontal";

    protected float m_forward;
    protected float m_sideway;
    #endregion

    #region Properties
    public float Forward
    {
        get { return m_forward; }
    }

    public float Sideway
    {
        get { return m_sideway; }
    }
    #endregion

    #region BuiltIn Methods
    private void Update()
    {
        HandleInput();
    }
    #endregion

    #region Custom Methods
    protected void HandleInput()
    {
        m_forward = Input.GetAxis(m_forwardAxis);
        m_sideway = Input.GetAxis(m_sidewayAxis);
    }
    #endregion
}

