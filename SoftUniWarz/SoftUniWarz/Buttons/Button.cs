using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SoftUniWarz.Background;

namespace SoftUniWarz.Buttons
{
    public abstract class Button
    {
        public event GUUClickableElement.ElementClickedEventHandler ClickEvent;
        //Lambda instead of delegate !
        public delegate void ElementClickedEventHandler(string element);

        private string buttonName;
        private GUIelements element;

        public Button(string name)
        {
            this.buttonName = name;
        }

        public GUIelements Element
        {
            get
            {
                return element;
            }

            set
            {
                element = value;
            }
        }

        public string ButtonName
        {
            get
            {
                return buttonName;
            }

            set
            {
                buttonName = value;
            }
        }
    }
}
