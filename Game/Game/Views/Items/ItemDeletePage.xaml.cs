﻿using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using PrimeAssault.Models;
using PrimeAssault.ViewModels;
using System;

namespace PrimeAssault.Views
{
    /// <summary>
    /// The Read Page
    /// </summary>
    [DesignTimeVisible(false)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemDeletePage : ContentPage
    {
        // View Model for Item
        readonly GenericViewModel<ItemModel> viewModel;

        // Empty Constructor for UTs
        public ItemDeletePage(bool UnitTest) { }

        // Constructor for Delete takes a view model of what to delete
        public ItemDeletePage(GenericViewModel<ItemModel> data)
        {
            InitializeComponent();

            BindingContext = this.viewModel = data;

            this.viewModel.Title = "Delete " + data.Title;
        }

        /// <summary>
        /// Save calls to Update
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public async void Delete_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "Delete", viewModel.Data);
            await Navigation.PopModalAsync();
        }

        /// <summary>
        /// Cancel and close this page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public async void Cancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        /// <summary>
        /// REturn to the previous page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }
}