using System;
using System.Collections.Generic;
using Sce.Pss.Core;
using Sce.Pss.Core.Imaging;
using Sce.Pss.Core.Environment;
using Sce.Pss.HighLevel.UI;

namespace PssUI1
{
    public partial class Scene1 : Scene
    {
        public Scene1()
        {
            InitializeWidget();
			HookThingsUp();
		}
		
		private void HookThingsUp()
		{
			SliderPercent.ValueChanged += (s, e) => {
				TipPercentText.Text = ((int)e.Value).ToString();
				Recalc();
			};
			TipPercentText.TextChanged += (s, e) => {
				SliderPercent.Value = int.Parse(TipPercentText.Text);
				Recalc();
			};
			TotalText.TextChanged += (s, e) => {
				Recalc();
			};
			Recalc();
		}
		
		private void Recalc()
		{
			var total = double.Parse(TotalText.Text);
			var tip = SliderPercent.Value * total / 100.0;
			total += tip;
			this.TipLabel.Text = tip.ToString();
			this.TotalLabel.Text = total.ToString(); 
		}	
    }
}
