using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using WpfUI.ServiceReference;

namespace WpfUI
{
    class AppViewModel : DependencyObject
    {

        ServiceClient client = new ServiceClient();
        public ICollectionView availabilityBooks
        {
            get { return (ICollectionView)GetValue(availabilityBooksProperty); }
            set { SetValue(availabilityBooksProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty availabilityBooksProperty =
            DependencyProperty.Register("availabilityBooks", typeof(ICollectionView), typeof(AppViewModel), new PropertyMetadata(null));




       


        public AppViewModel()
        {
            availabilityBooks = CollectionViewSource.GetDefaultView(client.AvailabilityBooks());
        }

    }
}
