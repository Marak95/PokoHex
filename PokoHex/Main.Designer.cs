using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace PokoHex;

partial class Main
{
    private IContainer components = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing)
            components?.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        menu = new MenuStrip();
        file = new ToolStripMenuItem();
        language = new ToolStripLabel();
        Menu_Language = new ToolStripComboBox();
        Menu_Language = new ToolStripComboBox();
        var open = new ToolStripMenuItem("&Open save folder...", null, Menu_Open_Click, Keys.Control | Keys.O);
        Menu_Export = new ToolStripMenuItem("&Export save copy...", null, Menu_Export_Click, Keys.Control | Keys.S);
        var exit = new ToolStripMenuItem("E&xit", null, Menu_Exit_Click);
        status = new StatusStrip();
        L_Status = new ToolStripStatusLabel();
        TC_Editor = new TabControl();
        player = new TabPage();
        name = new Label();
        TB_Name = new TextBox();
        nameHint = new Label();
        items = new TabPage();
        split = new SplitContainer();
        DGV_Items = new DataGridView();
        dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
        dataGridViewImageColumn1 = new DataGridViewImageColumn();
        dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
        inventoryPanel = new Panel();
        inventoryLabel = new Label();
        CB_Inventory = new ComboBox();
        L_Slot = new Label();
        itemLabel = new Label();
        CB_Item = new ComboBox();
        amount = new Label();
        NUD_Count = new NumericUpDown();
        B_Set = new Button();
        clear = new Button();
        L_Catalog = new Label();
        hint = new Label();
        villagers = new TabPage();
        Editor_Villagers = new VillagerEditor();
        map = new TabPage();
        Editor_Map = new MapEditor();
        menu.SuspendLayout();
        status.SuspendLayout();
        TC_Editor.SuspendLayout();
        player.SuspendLayout();
        items.SuspendLayout();
        ((ISupportInitialize)split).BeginInit();
        split.Panel1.SuspendLayout();
        split.Panel2.SuspendLayout();
        split.SuspendLayout();
        ((ISupportInitialize)DGV_Items).BeginInit();
        inventoryPanel.SuspendLayout();
        ((ISupportInitialize)NUD_Count).BeginInit();
        villagers.SuspendLayout();
        map.SuspendLayout();
        SuspendLayout();
        // 
        // menu
        // 
        menu.ImageScalingSize = new Size(20, 20);
        menu.Items.AddRange(new ToolStripItem[] { file, language, Menu_Language });
        menu.Location = new Point(0, 0);
        menu.Name = "menu";
        menu.Size = new Size(200, 24);
        menu.TabIndex = 2;
        // 
        // file
        // 
        file.Name = "file";
        file.Size = new Size(46, 20);
        file.Text = "&File";
        file.DropDownItems.AddRange(new ToolStripItem[] { open, Menu_Export, new ToolStripSeparator(), exit });
        // 
        // language
        // 
        language.Name = "language";
        language.Size = new Size(77, 17);
        language.Text = "Language:";
        // 
        // Menu_Language
        // 
        Menu_Language.DropDownStyle = ComboBoxStyle.DropDownList;
        Menu_Language.Items.AddRange(new object[] { "English", "日本語", "Deutsch", "Español", "Français", "Italiano", "한국어", "简体中文", "繁體中文" });
        Menu_Language.Name = "Menu_Language";
        Menu_Language.Size = new Size(130, 23);
        Menu_Language.SelectedIndexChanged += Menu_Language_SelectedIndexChanged;
        // 
        // status
        // 
        status.ImageScalingSize = new Size(20, 20);
        status.Items.AddRange(new ToolStripItem[] { L_Status });
        status.Location = new Point(0, 0);
        status.Name = "status";
        status.Size = new Size(200, 22);
        status.TabIndex = 1;
        // 
        // L_Status
        // 
        L_Status.Name = "L_Status";
        L_Status.Size = new Size(23, 23);
        L_Status.Text = "Open a save folder to begin.";
        // 
        // TC_Editor
        // 
        TC_Editor.Controls.Add(player);
        TC_Editor.Controls.Add(items);
        TC_Editor.Controls.Add(villagers);
        TC_Editor.Controls.Add(map);
        TC_Editor.Dock = DockStyle.Fill;
        TC_Editor.Enabled = false;
        TC_Editor.Location = new Point(0, 0);
        TC_Editor.Margin = new Padding(3, 4, 3, 4);
        TC_Editor.Name = "TC_Editor";
        TC_Editor.SelectedIndex = 0;
        TC_Editor.Size = new Size(229, 133);
        TC_Editor.TabIndex = 0;
        // 
        // player
        // 
        player.Controls.Add(name);
        player.Controls.Add(TB_Name);
        player.Controls.Add(nameHint);
        player.Location = new Point(4, 29);
        player.Margin = new Padding(3, 4, 3, 4);
        player.Name = "player";
        player.Padding = new Padding(14, 16, 14, 16);
        player.Size = new Size(221, 100);
        player.TabIndex = 0;
        player.Text = "Player";
        // 
        // name
        // 
        name.AutoSize = true;
        name.Location = new Point(25, 37);
        name.Name = "name";
        name.Size = new Size(93, 20);
        name.TabIndex = 0;
        name.Text = "Player name:";
        // 
        // TB_Name
        // 
        TB_Name.Location = new Point(144, 32);
        TB_Name.Margin = new Padding(3, 4, 3, 4);
        TB_Name.MaxLength = 24;
        TB_Name.Name = "TB_Name";
        TB_Name.Size = new Size(278, 27);
        TB_Name.TabIndex = 1;
        // 
        // nameHint
        // 
        nameHint.AutoSize = true;
        nameHint.Location = new Point(144, 80);
        nameHint.Name = "nameHint";
        nameHint.Size = new Size(151, 20);
        nameHint.TabIndex = 2;
        nameHint.Text = "Up to 24 UTF-8 bytes.";
        // 
        // items
        // 
        items.Controls.Add(split);
        items.Location = new Point(4, 29);
        items.Margin = new Padding(3, 4, 3, 4);
        items.Name = "items";
        items.Padding = new Padding(9, 11, 9, 11);
        items.Size = new Size(221, 100);
        items.TabIndex = 1;
        items.Text = "Items";
        // 
        // split
        // 
        split.Dock = DockStyle.Fill;
        split.FixedPanel = FixedPanel.Panel2;
        split.Location = new Point(9, 11);
        split.Margin = new Padding(3, 4, 3, 4);
        split.Name = "split";
        // 
        // split.Panel1
        // 
        split.Panel1.Controls.Add(DGV_Items);
        split.Panel1.Controls.Add(inventoryPanel);
        split.Panel1MinSize = 300;
        // 
        // split.Panel2
        // 
        split.Panel2.Controls.Add(L_Slot);
        split.Panel2.Controls.Add(itemLabel);
        split.Panel2.Controls.Add(CB_Item);
        split.Panel2.Controls.Add(amount);
        split.Panel2.Controls.Add(NUD_Count);
        split.Panel2.Controls.Add(B_Set);
        split.Panel2.Controls.Add(clear);
        split.Panel2.Controls.Add(L_Catalog);
        split.Panel2.Controls.Add(hint);
        split.Panel2MinSize = 310;
        split.Size = new Size(614, 112);
        split.SplitterDistance = 520;
        split.TabIndex = 0;
        // 
        // DGV_Items
        // 
        DGV_Items.AllowUserToAddRows = false;
        DGV_Items.AllowUserToDeleteRows = false;
        DGV_Items.AllowUserToResizeRows = false;
        DGV_Items.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        DGV_Items.BackgroundColor = SystemColors.Window;
        DGV_Items.ColumnHeadersHeight = 29;
        DGV_Items.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewImageColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
        DGV_Items.Dock = DockStyle.Fill;
        DGV_Items.Location = new Point(0, 36);
        DGV_Items.MultiSelect = false;
        DGV_Items.Name = "DGV_Items";
        DGV_Items.ReadOnly = true;
        DGV_Items.RowHeadersVisible = false;
        DGV_Items.RowHeadersWidth = 51;
        DGV_Items.RowTemplate.Height = 36;
        DGV_Items.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        DGV_Items.Size = new Size(520, 464);
        DGV_Items.TabIndex = 0;
        DGV_Items.CurrentCellChanged += DGV_Items_CurrentCellChanged;
        // 
        // dataGridViewTextBoxColumn1
        // 
        dataGridViewTextBoxColumn1.MinimumWidth = 6;
        dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
        dataGridViewTextBoxColumn1.ReadOnly = true;
        // 
        // dataGridViewImageColumn1
        // 
        dataGridViewImageColumn1.MinimumWidth = 6;
        dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
        dataGridViewImageColumn1.ReadOnly = true;
        // 
        // dataGridViewTextBoxColumn2
        // 
        dataGridViewTextBoxColumn2.MinimumWidth = 6;
        dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
        dataGridViewTextBoxColumn2.ReadOnly = true;
        // 
        // dataGridViewTextBoxColumn3
        // 
        dataGridViewTextBoxColumn3.MinimumWidth = 6;
        dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
        dataGridViewTextBoxColumn3.ReadOnly = true;
        // 
        // inventoryPanel
        // 
        inventoryPanel.Controls.Add(inventoryLabel);
        inventoryPanel.Controls.Add(CB_Inventory);
        inventoryPanel.Dock = DockStyle.Top;
        inventoryPanel.Location = new Point(0, 0);
        inventoryPanel.Name = "inventoryPanel";
        inventoryPanel.Size = new Size(520, 36);
        inventoryPanel.TabIndex = 1;
        // 
        // inventoryLabel
        // 
        inventoryLabel.AutoSize = true;
        inventoryLabel.Location = new Point(0, 8);
        inventoryLabel.Name = "inventoryLabel";
        inventoryLabel.Size = new Size(73, 20);
        inventoryLabel.TabIndex = 0;
        inventoryLabel.Text = "Inventory:";
        // 
        // CB_Inventory
        // 
        CB_Inventory.DropDownStyle = ComboBoxStyle.DropDownList;
        CB_Inventory.Items.AddRange(new object[] { "Main inventory", "Secondary bar" });
        CB_Inventory.Location = new Point(80, 4);
        CB_Inventory.Name = "CB_Inventory";
        CB_Inventory.Size = new Size(180, 28);
        CB_Inventory.TabIndex = 1;
        CB_Inventory.SelectedIndexChanged += CB_Inventory_SelectedIndexChanged;
        // 
        // L_Slot
        // 
        L_Slot.AutoSize = true;
        L_Slot.Location = new Point(16, 16);
        L_Slot.Name = "L_Slot";
        L_Slot.Size = new Size(35, 20);
        L_Slot.TabIndex = 0;
        L_Slot.Text = "Slot";
        // 
        // itemLabel
        // 
        itemLabel.AutoSize = true;
        itemLabel.Location = new Point(16, 55);
        itemLabel.Name = "itemLabel";
        itemLabel.Size = new Size(42, 20);
        itemLabel.TabIndex = 1;
        itemLabel.Text = "Item:";
        // 
        // CB_Item
        // 
        CB_Item.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        CB_Item.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        CB_Item.AutoCompleteSource = AutoCompleteSource.ListItems;
        CB_Item.DrawMode = DrawMode.OwnerDrawFixed;
        CB_Item.DropDownStyle = ComboBoxStyle.DropDownList;
        CB_Item.DropDownWidth = 440;
        CB_Item.ItemHeight = 30;
        CB_Item.Location = new Point(16, 78);
        CB_Item.Name = "CB_Item";
        CB_Item.Size = new Size(352, 36);
        CB_Item.TabIndex = 2;
        CB_Item.DrawItem += CB_Item_DrawItem;
        CB_Item.SelectedIndexChanged += CB_Item_SelectedIndexChanged;
        // 
        // amount
        // 
        amount.AutoSize = true;
        amount.Location = new Point(16, 135);
        amount.Name = "amount";
        amount.Size = new Size(65, 20);
        amount.TabIndex = 3;
        amount.Text = "Amount:";
        // 
        // NUD_Count
        // 
        NUD_Count.Location = new Point(94, 132);
        NUD_Count.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
        NUD_Count.Name = "NUD_Count";
        NUD_Count.Size = new Size(90, 27);
        NUD_Count.TabIndex = 4;
        // 
        // B_Set
        // 
        B_Set.Enabled = false;
        B_Set.Location = new Point(16, 174);
        B_Set.Name = "B_Set";
        B_Set.Size = new Size(100, 30);
        B_Set.TabIndex = 5;
        B_Set.Text = "Set";
        B_Set.Click += B_Set_Click;
        // 
        // clear
        // 
        clear.Location = new Point(126, 174);
        clear.Name = "clear";
        clear.Size = new Size(100, 30);
        clear.TabIndex = 6;
        clear.Text = "Clear";
        clear.Click += B_Clear_Click;
        // 
        // L_Catalog
        // 
        L_Catalog.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        L_Catalog.Location = new Point(16, 234);
        L_Catalog.Name = "L_Catalog";
        L_Catalog.Size = new Size(352, 42);
        L_Catalog.TabIndex = 7;
        L_Catalog.Text = "Item catalog";
        // 
        // hint
        // 
        hint.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        hint.Location = new Point(16, 296);
        hint.Name = "hint";
        hint.Size = new Size(352, 100);
        hint.TabIndex = 8;
        hint.Text = "Type an item name to search.\r\n\r\nSet applies the selected item and amount.\r\nZero clears the slot.\r\n\r\nExport saves your changes to a new folder.";
        // 
        // villagers
        // 
        villagers.Controls.Add(Editor_Villagers);
        villagers.Location = new Point(4, 29);
        villagers.Name = "villagers";
        villagers.Size = new Size(192, 67);
        villagers.TabIndex = 2;
        villagers.Text = "Villagers";
        // 
        // Editor_Villagers
        // 
        Editor_Villagers.Location = new Point(0, 0);
        Editor_Villagers.Margin = new Padding(3, 4, 3, 4);
        Editor_Villagers.Name = "Editor_Villagers";
        Editor_Villagers.Padding = new Padding(9, 11, 9, 11);
        Editor_Villagers.Size = new Size(1070, 688);
        Editor_Villagers.TabIndex = 0;
        // 
        // map
        // 
        map.Controls.Add(Editor_Map);
        map.Location = new Point(4, 29);
        map.Name = "map";
        map.Size = new Size(192, 67);
        map.TabIndex = 3;
        map.Text = "Map";
        // 
        // Editor_Map
        // 
        Editor_Map.Location = new Point(0, 0);
        Editor_Map.Margin = new Padding(3, 4, 3, 4);
        Editor_Map.Name = "Editor_Map";
        Editor_Map.Padding = new Padding(7, 8, 7, 8);
        Editor_Map.Size = new Size(1051, 867);
        Editor_Map.TabIndex = 0;
        // 
        // Main
        // 
        AllowDrop = true;
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1280, 1013);
        Controls.Add(TC_Editor);
        Controls.Add(status);
        Controls.Add(menu);
        MainMenuStrip = menu;
        Margin = new Padding(3, 4, 3, 4);
        MinimumSize = new Size(912, 624);
        Name = "Main";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "PokoHex";
        FormClosing += Main_FormClosing;
        DragDrop += Main_DragDrop;
        DragEnter += Main_DragEnter;
        menu.ResumeLayout(false);
        menu.PerformLayout();
        status.ResumeLayout(false);
        status.PerformLayout();
        TC_Editor.ResumeLayout(false);
        player.ResumeLayout(false);
        player.PerformLayout();
        items.ResumeLayout(false);
        split.Panel1.ResumeLayout(false);
        split.Panel2.ResumeLayout(false);
        split.Panel2.PerformLayout();
        ((ISupportInitialize)split).EndInit();
        split.ResumeLayout(false);
        ((ISupportInitialize)DGV_Items).EndInit();
        inventoryPanel.ResumeLayout(false);
        inventoryPanel.PerformLayout();
        ((ISupportInitialize)NUD_Count).EndInit();
        villagers.ResumeLayout(false);
        map.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    private ToolStripMenuItem Menu_Export = null!;
    private ToolStripComboBox Menu_Language = null!;
    private ToolStripStatusLabel L_Status = null!;
    private TabControl TC_Editor = null!;
    private TextBox TB_Name = null!;
    private DataGridView DGV_Items = null!;
    private ComboBox CB_Inventory = null!;
    private ComboBox CB_Item = null!;
    private NumericUpDown NUD_Count = null!;
    private Label L_Slot = null!;
    private Label L_Catalog = null!;
    private Button B_Set = null!;
    private VillagerEditor Editor_Villagers = null!;
    private MapEditor Editor_Map = null!;
    private MenuStrip menu;
    private ToolStripMenuItem file;
    private ToolStripLabel language;
    private StatusStrip status;
    private TabPage player;
    private Label name;
    private Label nameHint;
    private TabPage items;
    private SplitContainer split;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private DataGridViewImageColumn dataGridViewImageColumn1;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private Panel inventoryPanel;
    private Label inventoryLabel;
    private Label itemLabel;
    private Label amount;
    private Button clear;
    private Label hint;
    private TabPage villagers;
    private TabPage map;
}
