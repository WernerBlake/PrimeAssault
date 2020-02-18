﻿using System.ComponentModel;
using Xamarin.Forms;
using PrimeAssault.ViewModels;
using System;
using PrimeAssault.Models;

namespace PrimeAssault.Views
{
    /// <summary>
    /// The Read Page
    /// </summary>
    [DesignTimeVisible(false)]
    public partial class ScoreReadPage : ContentPage
    {
        // View Model for Score
        public readonly GenericViewModel<ScoreModel> ViewModel;

        public ScoreReadPage(bool UnitTest) { }

        /// <summary>
        /// Constructor called with a view model
        /// This is the primary way to open the page
        /// The viewModel is the data that should be displayed
        /// </summary>
        /// <param name="viewModel"></param>
        public ScoreReadPage(GenericViewModel<ScoreModel> data)
        {
            InitializeComponent();

            BindingContext = this.ViewModel = data;
        }

        /// <summary>
        /// Save calls to Update
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public async void Update_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new ScoreUpdatePage(new GenericViewModel<ScoreModel>(ViewModel.Data))));
            await Navigation.PopAsync();
        }

        /// <summary>
        /// Calls for Delete
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public async void Delete_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new ScoreDeletePage(new GenericViewModel<ScoreModel>(ViewModel.Data))));
            await Navigation.PopAsync();
        }
    }
}