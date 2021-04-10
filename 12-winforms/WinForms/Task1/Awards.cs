using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    public class Awards
    {
        private int _iD;
        public string _title;
        private string _description;

        public int ID
        {
            get
            {
                return _iD;
            }
            set
            {
                this._iD = value;
            }
        }
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                this._title = value;
            }
        }
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                this._description = value;
            }
        }
        public Awards(int ID, string Title, string Description)
        {
            this._iD = ID;
            this._title = Title;
            this._description = Description;
        }
    }
}
