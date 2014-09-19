﻿//      *********    DO NOT MODIFY THIS FILE     *********
//      This file is regenerated by a design tool. Making
//      changes to this file can cause errors.
namespace Blend.SampleData.MainPageSampleDataSource
{
	using System; 
	using System.ComponentModel;

// To significantly reduce the sample data footprint in your production application, you can set
// the DISABLE_SAMPLE_DATA conditional compilation constant and disable sample data at runtime.
#if DISABLE_SAMPLE_DATA
	internal class MainPageSampleDataSource { }
#else

	public class MainPageSampleDataSource : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		public MainPageSampleDataSource()
		{
			try
			{
				Uri resourceUri = new Uri("ms-appx:/SampleData/MainPageSampleDataSource/MainPageSampleDataSource.xaml", UriKind.RelativeOrAbsolute);
				Windows.UI.Xaml.Application.LoadComponent(this, resourceUri);
			}
			catch
			{
			}
		}

		private Books _Books = new Books();

		public Books Books
		{
			get
			{
				return this._Books;
			}
		}
	}

	public class BooksItem : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		private string _Title = string.Empty;

		public string Title
		{
			get
			{
				return this._Title;
			}

			set
			{
				if (this._Title != value)
				{
					this._Title = value;
					this.OnPropertyChanged("Title");
				}
			}
		}

		private string _LastOpeningTime = string.Empty;

		public string LastOpeningTime
		{
			get
			{
				return this._LastOpeningTime;
			}

			set
			{
				if (this._LastOpeningTime != value)
				{
					this._LastOpeningTime = value;
					this.OnPropertyChanged("LastOpeningTime");
				}
			}
		}
	}

	public class Books : System.Collections.ObjectModel.ObservableCollection<BooksItem>
	{ 
	}
#endif
}