using System;
using System.Collections.ObjectModel;

using auditpro.Models;
using auditpro.Services;

using GalaSoft.MvvmLight;

namespace auditpro.ViewModels
{
    public class ChartViewModel : ViewModelBase
    {
        public ChartViewModel()
        {
        }

        public ObservableCollection<DataPoint> Source
        {
            get
            {
                // TODO WTS: Replace this with your actual data
                return SampleDataService.GetChartSampleData();
            }
        }
    }
}
