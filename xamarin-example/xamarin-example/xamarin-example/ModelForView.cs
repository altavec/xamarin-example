using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace xamarin_example
{
	public class ModelForView : INotifyPropertyChanged
	{
		public ModelForView()
		{
            EntryText = "Hello World!";
            ButtonText = "Click Me";
            ListSource = new List<string>
            {
                "Item 1",
                "Item 2",
                "Item 3"/*,
                "Item 4",
                "Item 5"*/
            };
            ButtonCommand = new Command(() => EntryText = "Hello Altavec!");
        }

        private string localText;
        private string localText2;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

        public string EntryText
        {
            get
            {
                return localText;
            }
            set
            {
                localText = value;
                OnPropertyChanged("EntryText");
            }
        }

        public string ButtonText
        {
            get
            {
                return localText2;
            }
            set
            {
                localText2 = value;
                OnPropertyChanged("ButtonText");
            }
        }

        public ICommand ButtonCommand { get; set; }

        public List<string> ListSource { get; set; }
    }
}

