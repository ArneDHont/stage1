using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Inspect.Mobile.Framework.Xamarin.ComponentModel
{
    /// <summary>
    /// A base class for objects of which the properties must be observable.
    /// </summary>
    public class ObservableObject : INotifyPropertyChanged, INotifyPropertyChanging, ICanRaisePropertyChanged
    {
        /// <summary>
        /// Occurs after a property value changes.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Occurs before a property value changes.
        /// </summary>
        public event PropertyChangingEventHandler PropertyChanging;

        /// <summary>
        /// Extracts the name of the property from an Expression.
        /// </summary>
        /// <typeparam name="T">The type of the property</typeparam>
        /// <param name="propertyExpression">An expression returning the propert's name.</param>
        /// <returns>The name of the property returned by the expression.</returns>
        /// <exception cref="ArgumentNullException">If the expression is null.</exception>
        /// <exception cref="ArgumentException">If the expression does not represents a property.</exception>
        protected static string GetPropertyName<T>(Expression<Func<T>> propertyExpression)
        {
            if (propertyExpression == null)
            {
                throw new ArgumentNullException("propertyExpression");
            }

            var body = propertyExpression.Body as MemberExpression;

            if (body == null)
            {
                throw new ArgumentException("Expression must be a MemberExpression.", "propertyExpression");
            }

            var property = body.Member as PropertyInfo;

            if (property == null)
            {
                throw new ArgumentException("Member of MemberExpression must be a property.", "propertyExpression");
            }
            return property.Name;
        }

        /// <summary>
        /// Raises the PropertyChanged event if needed.
        /// </summary>
        /// <param name="propertyName">(optional) The name of the property that changed.</param>
        public virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Raises the PropertyChanged event if needed.
        /// </summary>
        /// <typeparam name="T">The type of the property that changed.</typeparam>
        /// <param name="propertyExpression"><An expression idenitfying the property that changed.</param>
        public virtual void RaisePropertyChanged<T>(Expression<Func<T>> propertyExpression)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(GetPropertyName(propertyExpression)));
        }

        /// <summary>
        /// Raises the PropertyChanging event if needed.
        /// </summary>
        /// <param name="propertyName">(optional) The name of the property that is changing.</param>
        public virtual void RaisePropertyChanging([CallerMemberName] string propertyName = null)
        {
            PropertyChanging?.Invoke(this, new PropertyChangingEventArgs(propertyName));
        }

        /// <summary>
        /// Raises the PropertyChanging event if needed.
        /// </summary>
        /// <typeparam name="T">The type of the property that is changing.</typeparam>
        /// <param name="propertyExpression">An expression identifying the property that is changing.</param>
        public virtual void RaisePropertyChanging<T>(Expression<Func<T>> propertyExpression)
        {
            PropertyChanging?.Invoke(this, new PropertyChangingEventArgs(GetPropertyName(propertyExpression)));
        }

        /// <summary>
        /// Assigns a new value to the property. Then raises the PropertyChanging and PropertyChanged
        /// event if needed.
        /// </summary>
        /// <typeparam name="T">The type of the property that is changing.</typeparam>
        /// <param name="propertyExpression">An expression identifying the property that is changing</param>
        /// <param name="field">The field storing the property's value.</param>
        /// <param name="newValue">The new value of the property after the change.</param>
        /// <returns>
        /// True if the PropertyChanged event has raised, otherwise false. The event is not raised
        /// when the old value is equal to the new value.
        /// </returns>
        protected bool Set<T>(Expression<Func<T>> propertyExpression, ref T field, T newValue)
        {
            if (EqualityComparer<T>.Default.Equals(field, newValue))
            {
                return false;
            }
            else
            {
                RaisePropertyChanging(propertyExpression);
                field = newValue;
                RaisePropertyChanged(propertyExpression);
                return true;
            }
        }

        /// <summary>
        /// Assigns a new value to the property. Then raises the PropertyChaning and PropertyChanged
        /// event if needed.
        /// </summary>
        /// <typeparam name="T">The type of the property that is changing.</typeparam>
        /// <param name="propertyName">The name of the property that is changing.</param>
        /// <param name="field">the field storing the property's value.</param>
        /// <param name="newValue">The new value of the property after the change.</param>
        /// <returns>
        /// True if the PropertyChanged event has raised, otherwise false. The event is not raised
        /// when the old value is equal to the new value.
        /// </returns>
        protected bool Set<T>(string propertyName, ref T field, T newValue)
        {
            if (EqualityComparer<T>.Default.Equals(field, newValue))
            {
                return false;
            }
            else
            {
                RaisePropertyChanging(propertyName);
                field = newValue;
                RaisePropertyChanged(propertyName);
                return true;
            }
        }

        /// <summary>
        /// Assigns a new value to the property. Then raises the PropertyChaning and PropertyChanged
        /// event if needed.
        /// </summary>
        /// <typeparam name="T">The type of the property that is changing.</typeparam>
        /// <param name="field">the field storing the property's value.</param>
        /// <param name="newValue">The new value of the property after the change.</param>
        /// <param name="propertyName">(optional) The name of the property that is changing.</param>
        /// <returns>
        /// True if the PropertyChanged event has raised, otherwise false. The event is not raised
        /// when the old value is equal to the new value.
        /// </returns>
        protected internal bool Set<T>(ref T field, T newValue, [CallerMemberName] string propertyName = null)
        {
            return Set(propertyName, ref field, newValue);
        }
    }
}
