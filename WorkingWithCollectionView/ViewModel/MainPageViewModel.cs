using System;
using BindingToObject.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithCollectionView.ViewModel
{
    internal class MainPageViewModel:INotifyPropertyChanged
    {
        public MainPageViewModel()
        {
            //נגדיר רשימה ריקה
            Students = new ObservableCollection<Student>();
            //נאתחל את התלמיד הבודד לריק
            Student = new() { Image = "dotnet_bot.svg", Name = "ברירת מחדל", BirthDate = new DateTime() };
        }


        //אוסף התלמידים
        public ObservableCollection<Student> Students { get; set; }

        #region כדי שהמסך יתעדכן כתוצאה מעדכון נתון עלינו להפעיל את אירוע בכל שינוי ערך שלו. לכן עלינו ליצור שדות מגבה

        private Student _student;//תלמיד נבחר
        #endregion

        #region בכל שינוי בשדות נפעיל את האירוע
        public Student Student { get => _student; set { if (_student != value) { _student = value; OnPropertyChanged("Student"); } } }

        #endregion


        /// <summary>
        /// פעולה הטוענת את נתוני התלמידים 
        /// מכיוון ש
        /// Students הוא ObeservableCollection
        /// הפקד המקושר יתעדכן אוטומטית
        /// </summary>
        private void LoadStudents()
        {
            this.Students.Clear();
            //דוגמה להוספת תלמיד בעקבות השינוי של גרסא 6 - אין צורך לציין אחרי
            //new שם מחלקה
            Students.Add(new() { Name = "Roni", Image = "roni.jpg", BirthDate = new DateTime(2006, 2, 19) });
            //הוספת תלמיד בדרך המלאה
            Students.Add(new Student { Name = "Omer", BirthDate = new DateTime(2006, 2, 9), Image = "omer.jpg" });
            Students.Add(new() { Name = "Ofir", Image = "jofir.jpg", BirthDate = new DateTime(1800, 11, 12) });
            Students.Add(new() { Name = "Aviv", Image = "aviv.jpg", BirthDate = new DateTime(2020, 1, 2) });
            Students.Add(new() { Name = "Gil", Image = "gil.jpg", BirthDate = new DateTime(1984, 6, 10) });
            Students.Add(new() { Name = "Maya", Image = "maya.jpg", BirthDate = new DateTime(2006, 10, 13) });

            Student = Students[0];

        }
    }
}
