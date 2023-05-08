using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class JoystickHandler : MonoBehaviour, IDragHandler, IPointerDownHandler, IPointerUpHandler
{
    //Данные джойстика
    [SerializeField] private Image joystickBackground;
    [SerializeField] private Image joystick;
    [SerializeField] private Image joystickArea;

    //Начальная позиция джойстика
    private Vector2 joystickBackgroundStartPosition;

    //Направление движения джойстика
    protected Vector2 inputVector;

    private bool joystickIsActive = false;


    private void Start()
    {
        ClickEffect();

        joystickBackgroundStartPosition = joystickBackground.rectTransform.anchoredPosition;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector2 joystickPosition;
        if (RectTransformUtility.ScreenPointToLocalPointInRectangle(joystickBackground.rectTransform, eventData.position, eventData.pressEventCamera, out joystickPosition))
        {
            joystickPosition.x = (joystickPosition.x * 2 / joystickBackground.rectTransform.sizeDelta.x);
            joystickPosition.y = (joystickPosition.y * 2 / joystickBackground.rectTransform.sizeDelta.y);

            inputVector = new Vector2(joystickPosition.x, joystickPosition.y);

            inputVector = (inputVector.magnitude > 1f) ? inputVector.normalized : inputVector;

            joystick.rectTransform.anchoredPosition = new Vector2(inputVector.x * (joystickBackground.rectTransform.sizeDelta.x / 2), 
                                                                                    inputVector.y * (joystickBackground.rectTransform.sizeDelta.y / 2));
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        ClickEffect();

        Vector2 joystickBackgroundPosition;

        if (RectTransformUtility.ScreenPointToLocalPointInRectangle(joystickArea.rectTransform, eventData.position, eventData.pressEventCamera, out joystickBackgroundPosition))
        {
            joystickBackground.rectTransform.anchoredPosition = new Vector2(joystickBackgroundPosition.x, joystickBackgroundPosition.y);
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        joystickBackground.rectTransform.anchoredPosition = joystickBackgroundStartPosition;

        ClickEffect();

        inputVector = Vector2.zero;
        joystick.rectTransform.anchoredPosition = Vector2.zero;
    }

    //Изменение прозрачности джойстика
    private void ClickEffect()
    {
        if (!joystickIsActive)
        {
            joystick.color = new Color (255f, 255f, 255f, 0.6f);
            joystickBackground.color = new Color (255f, 255f, 255f, 0.6f);
            joystickIsActive = true;
        }
        else
        {
            joystick.color = new Color (255f, 255f, 255f, 1f);
            joystickBackground.color = new Color (255f, 255f, 255f, 1f);
            joystickIsActive = false;
        }
    }
}
