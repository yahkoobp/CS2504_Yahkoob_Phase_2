using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CouterApp
{
    public class CounterViewModel : ViewModelBase
    {
        private int _count;
        public int Count
        {
            get { return _count; }
            set 
            { 
                this._count = value;
                onPropertyChanged(nameof(Count));
            }
        }
        public ICommand IncrementCommand { get; }
        public ICommand DecrementCommand { get; }
        public CounterViewModel()
        {
            this.Count = 100;
            IncrementCommand = new CommandBase(IncrementCount);
            DecrementCommand = new CommandBase(DecrementCount);
        }

        public void IncrementCount()
        {
            this.Count++;
        }

        public void DecrementCount()
        {
            this.Count--;
        }
    }
}
