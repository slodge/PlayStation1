// AUTOMATICALLY GENERATED CODE

using System;
using System.Collections.Generic;
using Sce.Pss.Core;
using Sce.Pss.Core.Imaging;
using Sce.Pss.Core.Environment;
using Sce.Pss.HighLevel.UI;

namespace PssUI1
{
    partial class Scene1
    {
        Label Label_1;
        EditableText TipPercentText;
        Slider SliderPercent;
        EditableText TotalText;
        Label label_0;
        Label Label_Tip;
        Label TipLabel;
        Label Label_5;
        Label TotalLabel;

        private void InitializeWidget()
        {
            InitializeWidget(LayoutOrientation.Horizontal);
        }

        private void InitializeWidget(LayoutOrientation orientation)
        {
            Label_1 = new Label();
            Label_1.Name = "Label_1";
            TipPercentText = new EditableText();
            TipPercentText.Name = "TipPercentText";
            SliderPercent = new Slider();
            SliderPercent.Name = "SliderPercent";
            TotalText = new EditableText();
            TotalText.Name = "TotalText";
            label_0 = new Label();
            label_0.Name = "label_0";
            Label_Tip = new Label();
            Label_Tip.Name = "Label_Tip";
            TipLabel = new Label();
            TipLabel.Name = "TipLabel";
            Label_5 = new Label();
            Label_5.Name = "Label_5";
            TotalLabel = new Label();
            TotalLabel.Name = "TotalLabel";

            // Label_1
            Label_1.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            Label_1.Font = new Font( FontAlias.System, 25, FontStyle.Regular);
            Label_1.LineBreak = LineBreak.Character;

            // TipPercentText
            TipPercentText.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            TipPercentText.Font = new Font( FontAlias.System, 25, FontStyle.Regular);
            TipPercentText.LineBreak = LineBreak.Character;

            // SliderPercent
            SliderPercent.MinValue = 0;
            SliderPercent.MaxValue = 100;
            SliderPercent.Value = 10;
            SliderPercent.Step = 1;

            // TotalText
            TotalText.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            TotalText.Font = new Font( FontAlias.System, 25, FontStyle.Regular);
            TotalText.LineBreak = LineBreak.Character;

            // label_0
            label_0.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            label_0.Font = new Font( FontAlias.System, 25, FontStyle.Regular);
            label_0.LineBreak = LineBreak.Character;

            // Label_Tip
            Label_Tip.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            Label_Tip.Font = new Font( FontAlias.System, 25, FontStyle.Regular);
            Label_Tip.LineBreak = LineBreak.Character;

            // TipLabel
            TipLabel.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            TipLabel.Font = new Font( FontAlias.System, 25, FontStyle.Regular);
            TipLabel.LineBreak = LineBreak.Character;

            // Label_5
            Label_5.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            Label_5.Font = new Font( FontAlias.System, 25, FontStyle.Regular);
            Label_5.LineBreak = LineBreak.Character;

            // TotalLabel
            TotalLabel.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            TotalLabel.Font = new Font( FontAlias.System, 25, FontStyle.Regular);
            TotalLabel.LineBreak = LineBreak.Character;

            // Scene
            this.RootWidget.AddChildLast(Label_1);
            this.RootWidget.AddChildLast(TipPercentText);
            this.RootWidget.AddChildLast(SliderPercent);
            this.RootWidget.AddChildLast(TotalText);
            this.RootWidget.AddChildLast(label_0);
            this.RootWidget.AddChildLast(Label_Tip);
            this.RootWidget.AddChildLast(TipLabel);
            this.RootWidget.AddChildLast(Label_5);
            this.RootWidget.AddChildLast(TotalLabel);

            SetWidgetLayout(orientation);

            UpdateLanguage();
        }

        private LayoutOrientation _currentLayoutOrientation;
        public void SetWidgetLayout(LayoutOrientation orientation)
        {
            switch (orientation)
            {
            case LayoutOrientation.Vertical:
                this.DesignWidth = 544;
                this.DesignHeight = 960;

                Label_1.SetPosition(55, 100);
                Label_1.SetSize(214, 36);
                Label_1.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Label_1.Visible = true;

                TipPercentText.SetPosition(55, 151);
                TipPercentText.SetSize(360, 56);
                TipPercentText.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                TipPercentText.Visible = true;

                SliderPercent.SetPosition(55, 224);
                SliderPercent.SetSize(362, 58);
                SliderPercent.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                SliderPercent.Visible = true;

                TotalText.SetPosition(55, 151);
                TotalText.SetSize(360, 56);
                TotalText.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                TotalText.Visible = true;

                label_0.SetPosition(55, 100);
                label_0.SetSize(214, 36);
                label_0.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                label_0.Visible = true;

                Label_Tip.SetPosition(64, 300);
                Label_Tip.SetSize(214, 36);
                Label_Tip.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Label_Tip.Visible = true;

                TipLabel.SetPosition(64, 300);
                TipLabel.SetSize(214, 36);
                TipLabel.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                TipLabel.Visible = true;

                Label_5.SetPosition(64, 300);
                Label_5.SetSize(214, 36);
                Label_5.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Label_5.Visible = true;

                TotalLabel.SetPosition(64, 300);
                TotalLabel.SetSize(214, 36);
                TotalLabel.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                TotalLabel.Visible = true;

                break;

            default:
                this.DesignWidth = 960;
                this.DesignHeight = 544;

                Label_1.SetPosition(55, 158);
                Label_1.SetSize(422, 36);
                Label_1.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Label_1.Visible = true;

                TipPercentText.SetPosition(503, 148);
                TipPercentText.SetSize(296, 56);
                TipPercentText.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                TipPercentText.Visible = true;

                SliderPercent.SetPosition(55, 222);
                SliderPercent.SetSize(744, 58);
                SliderPercent.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                SliderPercent.Visible = true;

                TotalText.SetPosition(500, 75);
                TotalText.SetSize(299, 56);
                TotalText.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                TotalText.Visible = true;

                label_0.SetPosition(55, 85);
                label_0.SetSize(422, 36);
                label_0.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                label_0.Visible = true;

                Label_Tip.SetPosition(57, 300);
                Label_Tip.SetSize(419, 36);
                Label_Tip.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Label_Tip.Visible = true;

                TipLabel.SetPosition(509, 301);
                TipLabel.SetSize(382, 36);
                TipLabel.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                TipLabel.Visible = true;

                Label_5.SetPosition(59, 365);
                Label_5.SetSize(419, 36);
                Label_5.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                Label_5.Visible = true;

                TotalLabel.SetPosition(511, 365);
                TotalLabel.SetSize(382, 36);
                TotalLabel.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                TotalLabel.Visible = true;

                break;
            }
            _currentLayoutOrientation = orientation;
        }
        public void UpdateLanguage()
        {
            Label_1.Text = "percent tip";
            TipPercentText.Text = "10";
            TotalText.Text = "60";
            TotalText.DefaultText = "60";
            label_0.Text = "bill";
            Label_Tip.Text = "tip";
            TipLabel.Text = "label";
            Label_5.Text = "total";
            TotalLabel.Text = "label";
        }
        private void onShowing(object sender, EventArgs e)
        {
            switch (_currentLayoutOrientation)
            {
                case LayoutOrientation.Vertical:
                {
                }
                break;

                default:
                {
                }
                break;
            }
        }
        private void onShown(object sender, EventArgs e)
        {
            switch (_currentLayoutOrientation)
            {
                case LayoutOrientation.Vertical:
                {
                }
                break;

                default:
                {
                }
                break;
            }
        }
    }
}
