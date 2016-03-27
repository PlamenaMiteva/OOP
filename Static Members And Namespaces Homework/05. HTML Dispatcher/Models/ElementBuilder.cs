namespace Models
{
    using System;
    using System.Collections.Generic;

    public class ElementBuilder
    {
        private string name;
        private List<string> element;

        public ElementBuilder(string name)
        {
            this.Name = name;
            this.Element = element;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Cannot create empty HTML element");
                }
                this.name = value;
            }
        }


        private List<string> Element
        {
            get { return this.element; }
            set
            {
                string str1 = "<" + this.name + ">";
                string str2 = "</" + this.name + ">";
                List<string> str = new List<string>();
                str.Add(str1);
                str.Add(str2);
                this.element = str;
            }
        }

        public string AddAttribute(string attribute, string atrrValue)
        {
            string elementStart = element[0];
            string atrr = " " + attribute + "=\"" + atrrValue + "\"";
            string result = elementStart.Insert(elementStart.Length - 1, atrr);
            element[0] = result;
            result += element[1];
            return result;
        }

        public string AddContent(string content)
        {
            string output = element[0] + content;
            element[0] = output;
            output += element[1];
            return output;
        }

        public static string operator *(ElementBuilder elem, int number)
        {
            string str = elem.element[0] + elem.element[1];
            for (int i = 0; i < number - 1; i++)
            {
                str += str;
            }
            return str;
        }
    }
}

