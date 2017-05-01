using System;

namespace SyncMvcAppCheckbox.Models
{
    public class TestViewModel
    {
        public Int32 Id { get; set; }
        public Boolean IsChecked1 { get; set; }
        public Boolean IsChecked2 { get; set; }
        public Boolean IsChecked3 { get; set; }

        public TestViewModel()
        {
            IsChecked1 = true;
            IsChecked2 = true;
            IsChecked3 = true;
        }
    }
}