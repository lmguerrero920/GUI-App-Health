using NutriApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NutriApp.ViewModels
{
   public class CardViewModel
    {
        public IEnumerable<CardModel> Items { get; set; }
        public CardViewModel()
        {
            Items = new CardModel[]
            {
                new CardModel(){ Title = "Calcular Dieta" , Image = "estrella.png"},
                new CardModel(){ Title = "Habitos Saludables" , Image = "comestibles.png"},
                new CardModel(){ Title = "Historias de vida Saludable" , Image = "lista.png"},
                new CardModel(){ Title = "Salud y vida" , Image = "settings_icon.png"},
                new CardModel(){ Title = "Bienestar" , Image = "estrella.png"},
            };
        }

    }
}
