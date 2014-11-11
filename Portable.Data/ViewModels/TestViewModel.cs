using System.Threading.Tasks;
using Portable.Data.Models;
using ReactiveUI;

namespace Portable.Data.ViewModels
{
    public class TestViewModel : ReactiveObject
    {
        private ReactiveList<TestModel> _listOfTestModels;
        private string _title;

        public ReactiveList<TestModel> ListOfTestModels
        {
            get { return _listOfTestModels; }
            set { _listOfTestModels = this.RaiseAndSetIfChanged(ref _listOfTestModels, value); }
        }

        public string Title
        {
            get { return _title; }
            set { _title = this.RaiseAndSetIfChanged(ref _title, value); }
        }

        public void InitializeRandomData()
        {
            ListOfTestModels.Add(new TestModel { Title = "Bowl of fruit", Subtitle = "Really!!"});
            ListOfTestModels.Add(new TestModel { Title = "Oreo cake", Subtitle = "Really!!"});
            ListOfTestModels.Add(new TestModel { Title = "Fudge", Subtitle = "Really!!"});
            ListOfTestModels.Add(new TestModel { Title = "Fonions", Subtitle = "Really!!"});
            ListOfTestModels.Add(new TestModel { Title = "Cereal", Subtitle = "Really!!"});
        }

        public async void DoRandomDataInsertionAtTimes()
        {
            var maxElements = 100;

            if (ListOfTestModels == null)
                ListOfTestModels = new ReactiveList<TestModel>();

            InitializeRandomData();

            for (var i = 0; i < maxElements; i++)
            {
                await Task.Delay(1500);

                ListOfTestModels.Add(new TestModel {Title = "Title: " + i, Subtitle = "" + i});
            }
        }
    }
}
