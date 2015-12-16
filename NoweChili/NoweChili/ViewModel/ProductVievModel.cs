using System;
using System.Windows.Input;
using Microsoft.TeamFoundation.MVVM;

namespace NoweChili.ViewModel
{
    public class ProductVievModel
    {
        public ICommand Command { get; set; }
        private int id { get; set; }



        public ProductVievModel()
        {
            Command = new RelayCommand(DeleteAction);
        }

        private void DeleteAction()
        {
            throw new NotImplementedException();
        }
    }
}
