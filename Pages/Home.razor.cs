﻿using BethanysPieShopHRM.App.Components.Widgets;

namespace BethanysPieShopHRM.App.Pages
{
    public partial class Home
    {
        public List<Type> Widgets { get; set; } = new List<Type>() { typeof(EmployeeCountWidget), typeof(InboxWidget) };
    }
}
