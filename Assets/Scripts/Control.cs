using UnityEngine;
using UnityEngine.InputSystem;

public class Control : MonoBehaviour, CharactorInput.IWarriorControlActions
{
    [SerializeField]
    GameObject warrior;
    [SerializeField]
    private float speed = 0.005f;
    private Vector2 inputVector;
    private CharactorInput charactorInputActions;
    private Animator animator;

    public void OnMove(InputAction.CallbackContext context)
    {
        Debug.Log("OnMove " + transform.position);
        inputVector = context.ReadValue<Vector2>();
    }

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
        animator = GetComponent<Animator>();
    }

    private void rotate(float x)
    {
        if (x < 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        else if (x > 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        float x = inputVector.x;
        float y = inputVector.y;
        if (x != 0 || y != 0)
        {
            transform.Translate(new Vector3(x, y, 0) * Time.deltaTime * speed);
            animator.SetBool("moving", true);
            rotate(x);
        }
        else
        {
            animator.SetBool("moving", false);
        }
    }

    private void OnEnable()
    {
        if (charactorInputActions == null)
        {
            charactorInputActions = new CharactorInput();
            charactorInputActions.WarriorControl.SetCallbacks(instance: this);
            charactorInputActions.WarriorControl.Enable();
        }
    }

    private void OnDisable()
    {
        charactorInputActions.WarriorControl.Disable();
    }

    public void OnAttack(InputAction.CallbackContext context)
    {
        Debug.Log("OnAttack " + transform.position);
        Debug.Log("OnAttack : " + animator.GetCurrentAnimatorStateInfo(0).IsName("Attack"));
        if (!animator.GetCurrentAnimatorStateInfo(0).IsName("Attack"))
        {
            animator.SetTrigger("attack");
        }
    }
}
