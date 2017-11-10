namespace FP_Growth
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.layoutControlMain = new DevExpress.XtraLayout.LayoutControl();
            this.gridControlResult = new DevExpress.XtraGrid.GridControl();
            this.gridViewResult = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ItemResult = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CoSoMau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FPTree = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MauPhoBien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnFPGrowth = new DevExpress.XtraEditors.SimpleButton();
            this.btnFPTree = new DevExpress.XtraEditors.SimpleButton();
            this.txtMincount = new DevExpress.XtraEditors.TextEdit();
            this.gridControlCount = new DevExpress.XtraGrid.GridControl();
            this.gridViewCount = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Item = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Count = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Items = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemsPhoBien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroupMain = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlMain)).BeginInit();
            this.layoutControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMincount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControlMain
            // 
            this.layoutControlMain.Controls.Add(this.gridControlResult);
            this.layoutControlMain.Controls.Add(this.btnFPGrowth);
            this.layoutControlMain.Controls.Add(this.btnFPTree);
            this.layoutControlMain.Controls.Add(this.txtMincount);
            this.layoutControlMain.Controls.Add(this.gridControlCount);
            this.layoutControlMain.Controls.Add(this.gridControl);
            this.layoutControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControlMain.Location = new System.Drawing.Point(0, 0);
            this.layoutControlMain.Name = "layoutControlMain";
            this.layoutControlMain.Root = this.layoutControlGroupMain;
            this.layoutControlMain.Size = new System.Drawing.Size(884, 461);
            this.layoutControlMain.TabIndex = 0;
            this.layoutControlMain.Text = "layoutControl1";
            // 
            // gridControlResult
            // 
            this.gridControlResult.Location = new System.Drawing.Point(12, 242);
            this.gridControlResult.MainView = this.gridViewResult;
            this.gridControlResult.Name = "gridControlResult";
            this.gridControlResult.Size = new System.Drawing.Size(696, 207);
            this.gridControlResult.TabIndex = 9;
            this.gridControlResult.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewResult});
            // 
            // gridViewResult
            // 
            this.gridViewResult.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ItemResult,
            this.CoSoMau,
            this.FPTree,
            this.MauPhoBien});
            this.gridViewResult.GridControl = this.gridControlResult;
            this.gridViewResult.Name = "gridViewResult";
            this.gridViewResult.OptionsView.ShowGroupPanel = false;
            // 
            // ItemResult
            // 
            this.ItemResult.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemResult.AppearanceCell.Options.UseFont = true;
            this.ItemResult.Caption = "Items";
            this.ItemResult.FieldName = "Items";
            this.ItemResult.Name = "ItemResult";
            this.ItemResult.Visible = true;
            this.ItemResult.VisibleIndex = 0;
            this.ItemResult.Width = 63;
            // 
            // CoSoMau
            // 
            this.CoSoMau.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoSoMau.AppearanceCell.Options.UseFont = true;
            this.CoSoMau.Caption = "Cơ sở mẫu điều kiện";
            this.CoSoMau.FieldName = "CoSoMau";
            this.CoSoMau.Name = "CoSoMau";
            this.CoSoMau.Visible = true;
            this.CoSoMau.VisibleIndex = 1;
            this.CoSoMau.Width = 153;
            // 
            // FPTree
            // 
            this.FPTree.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FPTree.AppearanceCell.Options.UseFont = true;
            this.FPTree.Caption = "FP-Tree điều kiện";
            this.FPTree.FieldName = "FPTree";
            this.FPTree.Name = "FPTree";
            this.FPTree.Visible = true;
            this.FPTree.VisibleIndex = 2;
            this.FPTree.Width = 159;
            // 
            // MauPhoBien
            // 
            this.MauPhoBien.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MauPhoBien.AppearanceCell.Options.UseFont = true;
            this.MauPhoBien.Caption = "Các mẫu phổ biến";
            this.MauPhoBien.FieldName = "MauPhoBien";
            this.MauPhoBien.Name = "MauPhoBien";
            this.MauPhoBien.Visible = true;
            this.MauPhoBien.VisibleIndex = 3;
            this.MauPhoBien.Width = 303;
            // 
            // btnFPGrowth
            // 
            this.btnFPGrowth.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFPGrowth.Appearance.Options.UseFont = true;
            this.btnFPGrowth.ImageUri.Uri = "Find;Size16x16";
            this.btnFPGrowth.Location = new System.Drawing.Point(712, 12);
            this.btnFPGrowth.Name = "btnFPGrowth";
            this.btnFPGrowth.Size = new System.Drawing.Size(160, 23);
            this.btnFPGrowth.StyleController = this.layoutControlMain;
            this.btnFPGrowth.TabIndex = 8;
            this.btnFPGrowth.Text = "FP-Growth";
            this.btnFPGrowth.Click += new System.EventHandler(this.btnFPGrowth_Click);
            // 
            // btnFPTree
            // 
            this.btnFPTree.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFPTree.Appearance.Options.UseFont = true;
            this.btnFPTree.ImageUri.Uri = "SortAsc;Size16x16";
            this.btnFPTree.Location = new System.Drawing.Point(557, 12);
            this.btnFPTree.Name = "btnFPTree";
            this.btnFPTree.Size = new System.Drawing.Size(151, 23);
            this.btnFPTree.StyleController = this.layoutControlMain;
            this.btnFPTree.TabIndex = 7;
            this.btnFPTree.Text = "FP-Tree";
            this.btnFPTree.Click += new System.EventHandler(this.btnFPTree_Click);
            // 
            // txtMincount
            // 
            this.txtMincount.Location = new System.Drawing.Point(98, 12);
            this.txtMincount.Name = "txtMincount";
            this.txtMincount.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMincount.Properties.Appearance.Options.UseFont = true;
            this.txtMincount.Properties.Mask.EditMask = "n0";
            this.txtMincount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtMincount.Size = new System.Drawing.Size(90, 22);
            this.txtMincount.StyleController = this.layoutControlMain;
            this.txtMincount.TabIndex = 6;
            this.txtMincount.EditValueChanged += new System.EventHandler(this.txtMincount_EditValueChanged);
            // 
            // gridControlCount
            // 
            this.gridControlCount.Location = new System.Drawing.Point(712, 55);
            this.gridControlCount.MainView = this.gridViewCount;
            this.gridControlCount.Name = "gridControlCount";
            this.gridControlCount.Size = new System.Drawing.Size(160, 394);
            this.gridControlCount.TabIndex = 5;
            this.gridControlCount.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCount});
            // 
            // gridViewCount
            // 
            this.gridViewCount.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Item,
            this.Count});
            this.gridViewCount.GridControl = this.gridControlCount;
            this.gridViewCount.Name = "gridViewCount";
            this.gridViewCount.OptionsView.ShowGroupPanel = false;
            // 
            // Item
            // 
            this.Item.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item.AppearanceCell.Options.UseFont = true;
            this.Item.Caption = "Item";
            this.Item.FieldName = "Items";
            this.Item.Name = "Item";
            this.Item.Visible = true;
            this.Item.VisibleIndex = 0;
            // 
            // Count
            // 
            this.Count.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Count.AppearanceCell.Options.UseFont = true;
            this.Count.Caption = "Count";
            this.Count.FieldName = "Count";
            this.Count.Name = "Count";
            this.Count.Visible = true;
            this.Count.VisibleIndex = 1;
            // 
            // gridControl
            // 
            this.gridControl.Location = new System.Drawing.Point(12, 55);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(696, 167);
            this.gridControl.TabIndex = 4;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.TID,
            this.Items,
            this.ItemsPhoBien});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsView.ShowGroupPanel = false;
            // 
            // TID
            // 
            this.TID.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TID.AppearanceCell.Options.UseFont = true;
            this.TID.Caption = "TID";
            this.TID.FieldName = "TID";
            this.TID.Name = "TID";
            this.TID.Visible = true;
            this.TID.VisibleIndex = 0;
            this.TID.Width = 94;
            // 
            // Items
            // 
            this.Items.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Items.AppearanceCell.Options.UseFont = true;
            this.Items.Caption = "Items";
            this.Items.FieldName = "Items";
            this.Items.Name = "Items";
            this.Items.Visible = true;
            this.Items.VisibleIndex = 1;
            this.Items.Width = 313;
            // 
            // ItemsPhoBien
            // 
            this.ItemsPhoBien.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemsPhoBien.AppearanceCell.Options.UseFont = true;
            this.ItemsPhoBien.Caption = "Items phổ biến";
            this.ItemsPhoBien.FieldName = "ItemsPhoBien";
            this.ItemsPhoBien.Name = "ItemsPhoBien";
            this.ItemsPhoBien.Visible = true;
            this.ItemsPhoBien.VisibleIndex = 2;
            this.ItemsPhoBien.Width = 271;
            // 
            // layoutControlGroupMain
            // 
            this.layoutControlGroupMain.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroupMain.GroupBordersVisible = false;
            this.layoutControlGroupMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.emptySpaceItem1,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6});
            this.layoutControlGroupMain.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroupMain.Name = "layoutControlGroupMain";
            this.layoutControlGroupMain.Size = new System.Drawing.Size(884, 461);
            this.layoutControlGroupMain.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 27);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(700, 187);
            this.layoutControlItem1.Text = "Table Items";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(83, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gridControlCount;
            this.layoutControlItem2.Location = new System.Drawing.Point(700, 27);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(164, 414);
            this.layoutControlItem2.Text = "Table Frequency ";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(83, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtMincount;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(180, 27);
            this.layoutControlItem3.Text = "MinCount:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(83, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(180, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(365, 27);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnFPTree;
            this.layoutControlItem4.Location = new System.Drawing.Point(545, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(155, 27);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnFPGrowth;
            this.layoutControlItem5.Location = new System.Drawing.Point(700, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(164, 27);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.gridControlResult;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 214);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(700, 227);
            this.layoutControlItem6.Text = "Table Result";
            this.layoutControlItem6.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(83, 13);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.layoutControlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FP - Growth";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlMain)).EndInit();
            this.layoutControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMincount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControlMain;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroupMain;
        private DevExpress.XtraGrid.GridControl gridControlCount;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCount;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.Columns.GridColumn TID;
        private DevExpress.XtraGrid.Columns.GridColumn Items;
        private DevExpress.XtraGrid.Columns.GridColumn Item;
        private DevExpress.XtraGrid.Columns.GridColumn Count;
        private DevExpress.XtraEditors.TextEdit txtMincount;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraGrid.Columns.GridColumn ItemsPhoBien;
        private DevExpress.XtraEditors.SimpleButton btnFPGrowth;
        private DevExpress.XtraEditors.SimpleButton btnFPTree;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraGrid.GridControl gridControlResult;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewResult;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraGrid.Columns.GridColumn ItemResult;
        private DevExpress.XtraGrid.Columns.GridColumn CoSoMau;
        private DevExpress.XtraGrid.Columns.GridColumn FPTree;
        private DevExpress.XtraGrid.Columns.GridColumn MauPhoBien;
    }
}

