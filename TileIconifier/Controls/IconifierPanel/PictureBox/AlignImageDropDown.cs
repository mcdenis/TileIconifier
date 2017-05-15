using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TileIconifier.Properties;

namespace TileIconifier.Controls.IconifierPanel.PictureBox
{
    sealed class AlignImageDropDown : ToolStripDropDown
    {
        private const string UNSUPPORTED_PROPERTY_ERROR =
            "This property is not currently supported by this control.";

        private ToolStripItem
            btnLeft,
            btnXMiddle,
            btnRight,
            btnTop,
            btnYMiddle,
            btnBottom,
            sep1,
            btnNudgeUp,
            btnNudgeLeft,
            btnAlignCenter,
            btnNudgeRight,
            btnNudgeDown,
            sep2,
            lblLocation;

        private Timer tmrNudge;

        private int _ticksCount = 0;
        private PannableImageAdjustement _lastClickType;

        public event EventHandler<AlignFormEventArgs> ImageLocationChanged;        

        public AlignImageDropDown(IContainer container)
        {
            if (container != null)
            {
                container.Add(this);
            }

            InitializeComponent();
        }

        #region "Properties"
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Obsolete(UNSUPPORTED_PROPERTY_ERROR)]
        [DefaultValue(ToolStripLayoutStyle.Table)]
        public new ToolStripLayoutStyle LayoutStyle
        {
            get { return base.LayoutStyle; }
            set { throw new NotSupportedException(UNSUPPORTED_PROPERTY_ERROR); }
        }

        protected override Padding DefaultPadding => new Padding(3);

        [DefaultValue(null)]
        public PannablePictureBox PannablePictureBox { get; set; }
        #endregion

        #region "Components initialization"
        private void InitializeComponent()
        {
            SuspendLayout();

            //Use base class since this class hides it.
            base.LayoutStyle = ToolStripLayoutStyle.Table;

            var layoutSettings = (TableLayoutSettings)LayoutSettings;
            layoutSettings.ColumnCount = 3;
            layoutSettings.RowCount = 7;

            var buttonDisplayStyle = ToolStripItemDisplayStyle.Image;
            var buttonPadding = new Padding(4, 0, 4, 0);

            //btnLeft
            btnLeft = Items.Add(Strings.AlignLeft, Resources.AlignLeft);
            btnLeft.DisplayStyle = buttonDisplayStyle;
            btnLeft.Padding = buttonPadding;
            btnLeft.Tag = PannableImageAdjustement.LeftAlign;
            layoutSettings.SetCellPosition(btnLeft, new TableLayoutPanelCellPosition(0, 0));

            //btnXMiddle
            btnXMiddle = Items.Add(Strings.AlignXMiddle, Resources.AlignXMiddle);
            btnXMiddle.DisplayStyle = buttonDisplayStyle;
            btnXMiddle.Padding = buttonPadding;
            btnXMiddle.Tag = PannableImageAdjustement.XAlign;
            layoutSettings.SetCellPosition(btnXMiddle, new TableLayoutPanelCellPosition(1, 0));

            //btnRight
            btnRight = Items.Add(Strings.AlignRight, Resources.AlignRight);
            btnRight.DisplayStyle = buttonDisplayStyle;
            btnRight.Padding = buttonPadding;
            btnRight.Tag = PannableImageAdjustement.RightAlign;
            layoutSettings.SetCellPosition(btnRight, new TableLayoutPanelCellPosition(2, 0));

            //btnTop
            btnTop = Items.Add(Strings.AlignTop, Resources.AlignTop);
            btnTop.DisplayStyle = buttonDisplayStyle;
            btnTop.Padding = buttonPadding;
            btnTop.Tag = PannableImageAdjustement.TopAlign;
            layoutSettings.SetCellPosition(btnTop, new TableLayoutPanelCellPosition(0, 1));

            //btnYMiddle
            btnYMiddle = Items.Add(Strings.AlignYMiddle, Resources.AlignYMiddle);
            btnYMiddle.DisplayStyle = buttonDisplayStyle;
            btnYMiddle.Padding = buttonPadding;
            btnYMiddle.Tag = PannableImageAdjustement.YAlign;
            layoutSettings.SetCellPosition(btnYMiddle, new TableLayoutPanelCellPosition(1, 1));
            
            //btnBottom
            btnBottom = Items.Add(Strings.AlignBottom, Resources.AlignBottom);
            btnBottom.DisplayStyle = buttonDisplayStyle;
            btnBottom.Padding = buttonPadding;
            btnBottom.Tag = PannableImageAdjustement.BottomAlign;
            layoutSettings.SetCellPosition(btnBottom, new TableLayoutPanelCellPosition(2, 1));

            //sep1
            sep1 = new HorizontalToolStripSeparator();
            sep1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            sep1.AutoSize = false;
            sep1.Height = 5;
            Items.Add(sep1);
            layoutSettings.SetCellPosition(sep1, new TableLayoutPanelCellPosition(0, 2));
            layoutSettings.SetColumnSpan(sep1, 3);

            //btnNudgeUp
            btnNudgeUp = Items.Add(Strings.NudgeUp, Resources.NudgeUp);
            btnNudgeUp.DisplayStyle = buttonDisplayStyle;
            btnNudgeUp.Padding = buttonPadding;
            btnNudgeUp.AutoToolTip = false;
            btnNudgeUp.Tag = PannableImageAdjustement.NudgeUp;
            layoutSettings.SetCellPosition(btnNudgeUp, new TableLayoutPanelCellPosition(1, 3));

            //btnNudgeLeft
            btnNudgeLeft = Items.Add(Strings.NudgeLeft, Resources.NudgeLeft);
            btnNudgeLeft.DisplayStyle = buttonDisplayStyle;
            btnNudgeLeft.Padding = buttonPadding;
            btnNudgeLeft.AutoToolTip = false;
            btnNudgeLeft.Tag = PannableImageAdjustement.NudgeLeft;
            layoutSettings.SetCellPosition(btnNudgeLeft, new TableLayoutPanelCellPosition(0, 4));

            //btnAlignCenter
            btnAlignCenter = Items.Add(Strings.AlignCentre, Resources.AlignCenter);
            btnAlignCenter.DisplayStyle = buttonDisplayStyle;
            btnAlignCenter.Padding = buttonPadding;
            btnAlignCenter.AutoToolTip = false;
            btnAlignCenter.Tag = PannableImageAdjustement.Center;
            layoutSettings.SetCellPosition(btnAlignCenter, new TableLayoutPanelCellPosition(1, 4));

            //btnNudgeRight
            btnNudgeRight = Items.Add(Strings.NudgeRight, Resources.NudgeRight);
            btnNudgeRight.DisplayStyle = buttonDisplayStyle;
            btnNudgeRight.Padding = buttonPadding;
            btnNudgeRight.AutoToolTip = false;
            btnNudgeRight.Tag = PannableImageAdjustement.NudgeRight;
            layoutSettings.SetCellPosition(btnNudgeRight, new TableLayoutPanelCellPosition(2, 4));

            //btnNudgeDown
            btnNudgeDown = Items.Add(Strings.NudgeDown, Resources.NudgeDown);
            btnNudgeDown.DisplayStyle = buttonDisplayStyle;
            btnNudgeDown.Padding = buttonPadding;
            btnNudgeDown.AutoToolTip = false;
            btnNudgeDown.Tag = PannableImageAdjustement.NudgeDown;
            layoutSettings.SetCellPosition(btnNudgeDown, new TableLayoutPanelCellPosition(1, 5));

            //sep2
            sep2 = new HorizontalToolStripSeparator();
            sep2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            sep2.AutoSize = false;
            sep2.Height = 5;
            Items.Add(sep2);
            layoutSettings.SetCellPosition(sep2, new TableLayoutPanelCellPosition(0, 6));
            layoutSettings.SetColumnSpan(sep2, 3);

            //lblLocation
            lblLocation = new ToolStripLabel();
            lblLocation.Anchor = AnchorStyles.None; //Center label
            Items.Add(lblLocation);
            //btnNudgeDown.DisplayStyle = ToolStripItemDisplayStyle.Image;
            layoutSettings.SetCellPosition(lblLocation, new TableLayoutPanelCellPosition(0, 7));
            layoutSettings.SetColumnSpan(lblLocation, 3);

            //tmrNudge
            tmrNudge = new Timer(Container);
            tmrNudge.Interval = 50;

            AddEventHandlers();

            ResumeLayout();            
        }
        #endregion

        protected override void OnOpened(EventArgs e)
        {
            SetPositionText();

            base.OnOpened(e);
        }

        protected override void OnClosing(ToolStripDropDownClosingEventArgs e)
        {
            if (e.CloseReason == ToolStripDropDownCloseReason.ItemClicked)
            {
                e.Cancel = true;
            }

            base.OnClosing(e);
        }

        private void AddEventHandlers()
        {
            btnLeft.Click += AlignButton_Click;
            btnRight.Click += AlignButton_Click;
            btnTop.Click += AlignButton_Click;
            btnBottom.Click += AlignButton_Click;
            btnXMiddle.Click += AlignButton_Click;
            btnYMiddle.Click += AlignButton_Click;
            btnAlignCenter.Click += AlignButton_Click;

            btnNudgeLeft.MouseDown += PanButton_MouseDown;
            btnNudgeDown.MouseDown += PanButton_MouseDown;
            btnNudgeUp.MouseDown += PanButton_MouseDown;
            btnNudgeRight.MouseDown += PanButton_MouseDown;
            btnNudgeLeft.MouseUp += PanButton_MouseUp;
            btnNudgeDown.MouseUp += PanButton_MouseUp;
            btnNudgeUp.MouseUp += PanButton_MouseUp;
            btnNudgeRight.MouseUp += PanButton_MouseUp;

            tmrNudge.Tick += TmrNudge_Tick;
        }

        private void AlignButton_Click(object sender, EventArgs e)
        {
            var item = (ToolStripItem)sender;
            var adjustementType = (PannableImageAdjustement)item.Tag;

            DoAdjustement(adjustementType);            
        }

        private void PanButton_MouseDown(object sender, MouseEventArgs e)
        {
            var item = (ToolStripItem)sender;
            var adjustementType = (PannableImageAdjustement)item.Tag;

            _lastClickType = adjustementType;
            //First adjustement immediatly when the button is down, before the delay is considered.
            DoAdjustement(adjustementType);            
            tmrNudge.Start();
        }

        private void PanButton_MouseUp(object sender, MouseEventArgs e)
        {
            var item = (ToolStripItem)sender;            
            tmrNudge.Stop();
            _ticksCount = 0;
        }

        private void DoAdjustement(PannableImageAdjustement adjustementType)
        {
            if (PannablePictureBox != null)
            {
                switch (adjustementType)
                {
                    case PannableImageAdjustement.LeftAlign:
                        PannablePictureBox.AlignLeft();
                        break;
                    case PannableImageAdjustement.BottomAlign:
                        PannablePictureBox.AlignBottom();
                        break;
                    case PannableImageAdjustement.RightAlign:
                        PannablePictureBox.AlignRight();
                        break;
                    case PannableImageAdjustement.TopAlign:
                        PannablePictureBox.AlignTop();
                        break;
                    case PannableImageAdjustement.XAlign:
                        PannablePictureBox.AlignXMiddle();
                        break;
                    case PannableImageAdjustement.YAlign:
                        PannablePictureBox.AlignYMiddle();
                        break;
                    case PannableImageAdjustement.NudgeUp:
                        PannablePictureBox.Nudge(y: -1);
                        break;
                    case PannableImageAdjustement.NudgeDown:
                        PannablePictureBox.Nudge(y: 1);
                        break;
                    case PannableImageAdjustement.NudgeLeft:
                        PannablePictureBox.Nudge(-1);
                        break;
                    case PannableImageAdjustement.NudgeRight:
                        PannablePictureBox.Nudge(1);
                        break;
                    case PannableImageAdjustement.Center:
                        PannablePictureBox.CenterImage();
                        break;
                    case PannableImageAdjustement.Unknown:
                    default:
                        throw new ArgumentOutOfRangeException(nameof(adjustementType), adjustementType, null);
                }

                SetPositionText();

                ImageLocationChanged?.Invoke(this, new AlignFormEventArgs(adjustementType));
            }            
        }

        private void SetPositionText()
        {
            var x = PannablePictureBox.PannablePictureBoxImage.X;
            var y = PannablePictureBox.ClientSize.Height //Because the PannablePictureBox uses its full size instead of its client size, Y=0 gives Y=-2. To correctly fix this issue, use the ClientSize in PannablePictureBox.
                - PannablePictureBox.PannablePictureBoxImage.Y - PannablePictureBox.PannablePictureBoxImage.Height;

            lblLocation.Text = string.Format("X: {0}   Y: {1}", x, y);
        }

        private void TmrNudge_Tick(object sender, EventArgs e)
        {
            if (_ticksCount++ > 4) //4 is a empirical number of ticks that yield a functinonal delay.
            {
                DoAdjustement(_lastClickType);
            }            
        }

        class HorizontalToolStripSeparator : ToolStripSeparator
        {
            protected override void OnPaint(PaintEventArgs e)
            {
                if (Owner != null && Parent != null)
                {
                    Owner.Renderer.DrawSeparator(new ToolStripSeparatorRenderEventArgs(e.Graphics, this, false));
                }
            }
        }
    }    
}
