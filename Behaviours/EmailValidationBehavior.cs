using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;
namespace ThinkOwn.Behaviours
{
    public class EmailValidationBehavior :Behavior<UraniumUI.Material.Controls.TextField>
    {
        public static readonly BindableProperty IsValidProperty =
           BindableProperty.Create(nameof(IsValid), typeof(bool), typeof(EmailValidationBehavior), false);
        public bool IsValid
        {
            get => (bool)GetValue(IsValidProperty);
            set => SetValue(IsValidProperty, value);
        }
        protected override void OnAttachedTo(UraniumUI.Material.Controls.TextField entry)
        {
            base.OnAttachedTo(entry);
            entry.TextChanged += OnTextChanged;
        }

        protected override void OnDetachingFrom(UraniumUI.Material.Controls.TextField entry)
        {
            base.OnDetachingFrom(entry);
            entry.TextChanged -= OnTextChanged;
        }
        private void OnTextChanged(object sender, TextChangedEventArgs e)
        {
            var entry = sender as UraniumUI.Material.Controls.TextField;
            if (entry != null)
            {
                IsValid = IsValidEmail(entry.Text);

                entry.TextColor = IsValid ? Color.FromHex("#00FF00") : Color.FromHex("#FF0000");
               //entry.TitleColor = IsValid? Color.FromHex("#00FF00") : Color.FromHex("#FF0000");

            }
        }
        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrEmpty(email)) return false;

            var emailRegex = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
            return emailRegex.IsMatch(email);
        }
    }
}
