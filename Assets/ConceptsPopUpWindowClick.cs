using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ConceptsPopUpWindowClick : MonoBehaviour
{
    [SerializeField] public ConceptsPopUpWindow conceptsWindow;
    public GameObject ConceptsBoard;
    public GameObject ConceptsPrint;
    public GameObject ConceptsComment;
    public GameObject ConceptsInteger;
    public GameObject ConceptsFloat;
    public GameObject ConceptsString;
    public GameObject ConceptsAdd;
    public GameObject Concepts;
    public void OKClicked()
    {
        conceptsWindow.gameObject.SetActive(false);
        ConceptsBoard.gameObject.SetActive(true);
        ConceptsPrint.gameObject.SetActive(true);
        ConceptsComment.gameObject.SetActive(true);
        ConceptsInteger.gameObject.SetActive(true);
        ConceptsFloat.gameObject.SetActive(true);
        ConceptsString.gameObject.SetActive(true);
        ConceptsAdd.gameObject.SetActive(true);
        Concepts.gameObject.SetActive(true);
    }

    public void openPopUp(string message)
    {
        conceptsWindow.gameObject.SetActive(true);
        ConceptsBoard.gameObject.SetActive(false);
        ConceptsPrint.gameObject.SetActive(false);
        ConceptsComment.gameObject.SetActive(false);
        ConceptsInteger.gameObject.SetActive(false);
        ConceptsFloat.gameObject.SetActive(false);
        ConceptsString.gameObject.SetActive(false);
        ConceptsAdd.gameObject.SetActive(false);
        Concepts.gameObject.SetActive(false);

        conceptsWindow.OK.onClick.AddListener(OKClicked); 
        if (message == "Print")
        {
            conceptsWindow.conceptTitle.text = "Print Function";
            conceptsWindow.conceptText.text = "The print() function in Python is used to display information on the screen. You can print text, numbers, or any other data you want to see while running your program. For example, below example will print 'Hello World!' :";
            conceptsWindow.conceptCode.text = "print(\"Hello, World!\")";
        }
        else if (message == "comment")
        {
            conceptsWindow.conceptTitle.text = "Comment";
            conceptsWindow.conceptText.text = "In Python, a comment is a piece of text within your code that is not executed. It's used to make notes or explain what certain parts of your code do. Comments start with the # symbol. For example:";
            conceptsWindow.conceptCode.text = "# This is a comment\r\nprint(\"Hello, World!\")  \n# This is also a comment";
        }
        else if (message == "integer")
        {
            conceptsWindow.conceptTitle.text = "Integer";
            conceptsWindow.conceptText.text = "An integer in Python is a whole number, positive or negative, without any decimal point. For example: 1, 0, -3, 100, etc. You can perform arithmetic operations like addition, subtraction, multiplication, and division on integers.";
            conceptsWindow.conceptCode.text = "x = 5  # This is an integer\r\ny = -10  # This is also an integer\r\nresult = x + y  # Result is 5 + (-10) = -5\r\nprint(result)  # Output: -5";
        }
        else if (message == "float")
        {
            conceptsWindow.conceptTitle.text = "Float";
            conceptsWindow.conceptText.text = "A float in Python represents a number that has a decimal point or is an exponential number. For example: 3.14, -0.5, 2.0, 1.618, etc. Floats are used when more precision is needed in calculations compared to integers.";
            conceptsWindow.conceptCode.text = "pi = 3.14  # This is a float\r\nradius = 2.5  # This is also a float\r\narea = pi * (radius ** 2)  # Calculating the area of a circle using a float\r\nprint(area)  # Output: 19.625";
        }
        else if (message == "string")
        {
            conceptsWindow.conceptTitle.text = "String";
            conceptsWindow.conceptText.text = "A string in Python is a sequence of characters, enclosed within single (' '), double (\" \"), or triple (''' ''' or \"\"\" \"\"\") quotes. Strings are used to represent text or any sequence of characters. Strings can be manipulated, sliced, and combined to create more complex texts or messages in your programs.";
            conceptsWindow.conceptCode.text = "name = \"Alice\"  # This is a string\r\nsentence = \"Hello, \" + name + \"!\"  # Concatenating strings\r\nprint(sentence)  # Output: Hello, Alice!";
        }
        else
        {
            conceptsWindow.conceptTitle.text = "List";
            conceptsWindow.conceptText.text = "In Python, a list is a collection of items, which can be of different data types, such as integers, floats, strings, or even other lists. Lists are defined by square brackets [] and items within the list are separated by commas. Lists are versatile and allow you to store and manipulate multiple values.";
            conceptsWindow.conceptCode.text = "fruits = [\"apple\", \"banana\", \"orange\", \"grape\"]  # This is a list of strings\r\nnumbers = [1, 2, 3, 4, 5]  # This is a list of integers\r\nmixed_list = [\"apple\", 3, 3.14, True]  # This is a list with different data types\r\n\r\nprint(fruits[0])  # Output: apple (Indexing starts from 0)\r\nprint(numbers[2])  # Output: 3\r\nprint(mixed_list[1])  # Output: 3.14\r\n\r\nfruits.append(\"cherry\")  # Adds \"cherry\" to the end of the fruits list\r\nprint(fruits)  # Output: [\"apple\", \"banana\", \"orange\", \"grape\", \"cherry\"]";
        }
    }
}
