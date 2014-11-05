
using System;
using System.ComponentModel;
using System.Linq.Expressions;

namespace NuGetPackageExplorer.Core
{
	public abstract class ViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		public string PropertyChangedFor<TModel, TProperty>(Expression<Func<TModel, TProperty>> expression)
		{
			MemberExpression memberExpression = expression.Body as MemberExpression;
			return PropertyChangedFor(memberExpression);
		}

		string PropertyChangedFor(MemberExpression memberExpression)
		{
			if (memberExpression != null) {
				return memberExpression.Member.Name;
			}
			return String.Empty;
		}

		protected void OnPropertyChanged<TModel, TProperty>(Expression<Func<TModel, TProperty>> expression)
		{
			string propertyName = PropertyChangedFor(expression);
			OnPropertyChanged(propertyName);
		}

		protected void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null) {
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}

