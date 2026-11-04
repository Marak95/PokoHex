using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace PokoHex;

partial class MapEditor
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
        filters = new Panel();
        btnJumpToInteriors = new Button();
        interior = new Label();
        CB_Interior = new ComboBox();
        area = new Label();
        CB_Area = new ComboBox();
        chunk = new Label();
        CB_Chunk = new ComboBox();
        height = new Label();
        NUD_Height = new NumericUpDown();
        CHK_AllHeights = new CheckBox();
        search = new Label();
        TB_Search = new TextBox();
        L_Count = new Label();
        split = new SplitContainer();
        PB_Map = new PictureBox();
        details = new Panel();
        checkBox1 = new CheckBox();
        LB_Parts = new ListBox();
        GB_Details = new GroupBox();
        PB_Item = new PictureBox();
        L_Item = new Label();
        L_Details = new Label();
        replacement = new Label();
        L_EditStatus = new Label();
        CB_Item = new ComboBox();
        x = new Label();
        y = new Label();
        z = new Label();
        NUD_X = new NumericUpDown();
        NUD_Y = new NumericUpDown();
        NUD_Z = new NumericUpDown();
        direction = new Label();
        CB_Direction = new ComboBox();
        B_Set = new Button();
        B_Undo = new Button();
        B_Redo = new Button();
        L_Coordinates = new Label();
        filters.SuspendLayout();
        ((ISupportInitialize)NUD_Height).BeginInit();
        ((ISupportInitialize)split).BeginInit();
        split.Panel1.SuspendLayout();
        split.Panel2.SuspendLayout();
        split.SuspendLayout();
        ((ISupportInitialize)PB_Map).BeginInit();
        details.SuspendLayout();
        GB_Details.SuspendLayout();
        ((ISupportInitialize)PB_Item).BeginInit();
        ((ISupportInitialize)NUD_X).BeginInit();
        ((ISupportInitialize)NUD_Y).BeginInit();
        ((ISupportInitialize)NUD_Z).BeginInit();
        SuspendLayout();
        // 
        // filters
        // 
        filters.Controls.Add(btnJumpToInteriors);
        filters.Controls.Add(interior);
        filters.Controls.Add(CB_Interior);
        filters.Controls.Add(area);
        filters.Controls.Add(CB_Area);
        filters.Controls.Add(chunk);
        filters.Controls.Add(CB_Chunk);
        filters.Controls.Add(height);
        filters.Controls.Add(NUD_Height);
        filters.Controls.Add(CHK_AllHeights);
        filters.Controls.Add(search);
        filters.Controls.Add(TB_Search);
        filters.Dock = DockStyle.Top;
        filters.Location = new Point(0, 0);
        filters.Margin = new Padding(3, 4, 3, 4);
        filters.Name = "filters";
        filters.Size = new Size(995, 123);
        filters.TabIndex = 1;
        // 
        // btnJumpToInteriors
        // 
        btnJumpToInteriors.Location = new Point(744, 43);
        btnJumpToInteriors.Name = "btnJumpToInteriors";
        btnJumpToInteriors.Size = new Size(230, 29);
        btnJumpToInteriors.TabIndex = 13;
        btnJumpToInteriors.Text = "Jump to main interiors";
        btnJumpToInteriors.UseVisualStyleBackColor = true;
        btnJumpToInteriors.Click += btnJumpToInteriors_Click;
        // 
        // interior
        // 
        interior.Location = new Point(673, 13);
        interior.Name = "interior";
        interior.Size = new Size(65, 27);
        interior.TabIndex = 11;
        interior.Text = "Interior:";
        // 
        // CB_Interior
        // 
        CB_Interior.DropDownStyle = ComboBoxStyle.DropDownList;
        CB_Interior.Location = new Point(744, 8);
        CB_Interior.Margin = new Padding(3, 4, 3, 4);
        CB_Interior.Name = "CB_Interior";
        CB_Interior.Size = new Size(230, 28);
        CB_Interior.TabIndex = 12;
        CB_Interior.SelectedIndexChanged += CB_Interior_SelectedIndexChanged;
        // 
        // area
        // 
        area.Location = new Point(5, 13);
        area.Name = "area";
        area.Size = new Size(53, 27);
        area.TabIndex = 0;
        area.Text = "Area:";
        // 
        // CB_Area
        // 
        CB_Area.DropDownStyle = ComboBoxStyle.DropDownList;
        CB_Area.Location = new Point(59, 8);
        CB_Area.Margin = new Padding(3, 4, 3, 4);
        CB_Area.Name = "CB_Area";
        CB_Area.Size = new Size(274, 28);
        CB_Area.TabIndex = 1;
        CB_Area.SelectedIndexChanged += CB_Area_SelectedIndexChanged;
        // 
        // chunk
        // 
        chunk.Location = new Point(350, 13);
        chunk.Name = "chunk";
        chunk.Size = new Size(62, 27);
        chunk.TabIndex = 2;
        chunk.Text = "Region:";
        // 
        // CB_Chunk
        // 
        CB_Chunk.DropDownStyle = ComboBoxStyle.DropDownList;
        CB_Chunk.Location = new Point(418, 8);
        CB_Chunk.Margin = new Padding(3, 4, 3, 4);
        CB_Chunk.Name = "CB_Chunk";
        CB_Chunk.Size = new Size(230, 28);
        CB_Chunk.TabIndex = 3;
        CB_Chunk.SelectedIndexChanged += View_Changed;
        // 
        // height
        // 
        height.Location = new Point(5, 56);
        height.Name = "height";
        height.Size = new Size(66, 27);
        height.TabIndex = 4;
        height.Text = "Layer Y:";
        // 
        // NUD_Height
        // 
        NUD_Height.Location = new Point(75, 51);
        NUD_Height.Margin = new Padding(3, 4, 3, 4);
        NUD_Height.Maximum = new decimal(new int[] { 127, 0, 0, 0 });
        NUD_Height.Name = "NUD_Height";
        NUD_Height.Size = new Size(75, 27);
        NUD_Height.TabIndex = 5;
        NUD_Height.Value = new decimal(new int[] { 37, 0, 0, 0 });
        NUD_Height.ValueChanged += View_Changed;
        // 
        // CHK_AllHeights
        // 
        CHK_AllHeights.Checked = true;
        CHK_AllHeights.CheckState = CheckState.Checked;
        CHK_AllHeights.Location = new Point(171, 51);
        CHK_AllHeights.Margin = new Padding(3, 4, 3, 4);
        CHK_AllHeights.Name = "CHK_AllHeights";
        CHK_AllHeights.Size = new Size(160, 32);
        CHK_AllHeights.TabIndex = 6;
        CHK_AllHeights.Text = "Show all heights";
        CHK_AllHeights.CheckedChanged += checkBox1_CheckedChanged;
        // 
        // search
        // 
        search.Location = new Point(350, 56);
        search.Name = "search";
        search.Size = new Size(62, 27);
        search.TabIndex = 7;
        search.Text = "Search:";
        // 
        // TB_Search
        // 
        TB_Search.Location = new Point(418, 51);
        TB_Search.Margin = new Padding(3, 4, 3, 4);
        TB_Search.Name = "TB_Search";
        TB_Search.Size = new Size(230, 27);
        TB_Search.TabIndex = 8;
        TB_Search.TextChanged += TB_Search_TextChanged;
        // 
        // L_Count
        // 
        L_Count.Dock = DockStyle.Top;
        L_Count.Location = new Point(0, 0);
        L_Count.Name = "L_Count";
        L_Count.Size = new Size(531, 27);
        L_Count.TabIndex = 9;
        L_Count.TextAlign = ContentAlignment.TopRight;
        // 
        // split
        // 
        split.Dock = DockStyle.Fill;
        split.FixedPanel = FixedPanel.Panel2;
        split.Location = new Point(7, 8);
        split.Margin = new Padding(3, 4, 3, 4);
        split.Name = "split";
        // 
        // split.Panel1
        // 
        split.Panel1.Controls.Add(PB_Map);
        split.Panel1.Controls.Add(filters);
        split.Panel1MinSize = 280;
        // 
        // split.Panel2
        // 
        split.Panel2.Controls.Add(details);
        split.Panel2MinSize = 350;
        split.Size = new Size(1531, 1179);
        split.SplitterDistance = 995;
        split.SplitterWidth = 5;
        split.TabIndex = 0;
        // 
        // PB_Map
        // 
        PB_Map.Dock = DockStyle.Fill;
        PB_Map.Location = new Point(0, 123);
        PB_Map.Margin = new Padding(3, 4, 3, 4);
        PB_Map.Name = "PB_Map";
        PB_Map.Size = new Size(995, 1056);
        PB_Map.TabIndex = 0;
        PB_Map.TabStop = false;
        PB_Map.Paint += PB_Map_Paint;
        PB_Map.MouseDown += PB_Map_MouseDown;
        PB_Map.MouseMove += PB_Map_MouseMove;
        // 
        // details
        // 
        details.AutoScroll = true;
        details.Controls.Add(checkBox1);
        details.Controls.Add(LB_Parts);
        details.Controls.Add(L_Count);
        details.Controls.Add(GB_Details);
        details.Dock = DockStyle.Fill;
        details.Location = new Point(0, 0);
        details.Margin = new Padding(3, 4, 3, 4);
        details.Name = "details";
        details.Size = new Size(531, 1179);
        details.TabIndex = 0;
        // 
        // checkBox1
        // 
        checkBox1.Location = new Point(1, -2);
        checkBox1.Name = "checkBox1";
        checkBox1.Size = new Size(151, 27);
        checkBox1.TabIndex = 12;
        checkBox1.Text = "Only in this region";
        checkBox1.UseVisualStyleBackColor = true;
        checkBox1.CheckedChanged += checkBox1_CheckedChanged;
        // 
        // LB_Parts
        // 
        LB_Parts.Dock = DockStyle.Fill;
        LB_Parts.DrawMode = DrawMode.OwnerDrawFixed;
        LB_Parts.IntegralHeight = false;
        LB_Parts.ItemHeight = 32;
        LB_Parts.Location = new Point(0, 27);
        LB_Parts.Margin = new Padding(3, 4, 3, 4);
        LB_Parts.Name = "LB_Parts";
        LB_Parts.Size = new Size(531, 675);
        LB_Parts.TabIndex = 1;
        LB_Parts.DrawItem += LB_Parts_DrawItem;
        LB_Parts.SelectedIndexChanged += LB_Parts_SelectedIndexChanged;
        // 
        // GB_Details
        // 
        GB_Details.Controls.Add(PB_Item);
        GB_Details.Controls.Add(L_Item);
        GB_Details.Controls.Add(L_Details);
        GB_Details.Controls.Add(replacement);
        GB_Details.Controls.Add(L_EditStatus);
        GB_Details.Controls.Add(CB_Item);
        GB_Details.Controls.Add(x);
        GB_Details.Controls.Add(y);
        GB_Details.Controls.Add(z);
        GB_Details.Controls.Add(NUD_X);
        GB_Details.Controls.Add(NUD_Y);
        GB_Details.Controls.Add(NUD_Z);
        GB_Details.Controls.Add(direction);
        GB_Details.Controls.Add(CB_Direction);
        GB_Details.Controls.Add(B_Set);
        GB_Details.Controls.Add(B_Undo);
        GB_Details.Controls.Add(B_Redo);
        GB_Details.Dock = DockStyle.Bottom;
        GB_Details.Location = new Point(0, 702);
        GB_Details.Margin = new Padding(3, 4, 3, 4);
        GB_Details.Name = "GB_Details";
        GB_Details.Padding = new Padding(3, 4, 3, 4);
        GB_Details.Size = new Size(531, 477);
        GB_Details.TabIndex = 0;
        GB_Details.TabStop = false;
        GB_Details.Text = "Placement";
        // 
        // PB_Item
        // 
        PB_Item.Location = new Point(14, 29);
        PB_Item.Margin = new Padding(3, 4, 3, 4);
        PB_Item.Name = "PB_Item";
        PB_Item.Size = new Size(73, 85);
        PB_Item.SizeMode = PictureBoxSizeMode.Zoom;
        PB_Item.TabIndex = 0;
        PB_Item.TabStop = false;
        // 
        // L_Item
        // 
        L_Item.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        L_Item.Location = new Point(105, 24);
        L_Item.Name = "L_Item";
        L_Item.Size = new Size(123, 37);
        L_Item.TabIndex = 1;
        // 
        // L_Details
        // 
        L_Details.Location = new Point(105, 61);
        L_Details.Name = "L_Details";
        L_Details.Size = new Size(325, 53);
        L_Details.TabIndex = 2;
        // 
        // replacement
        // 
        replacement.Location = new Point(14, 132);
        replacement.Name = "replacement";
        replacement.Size = new Size(274, 27);
        replacement.TabIndex = 3;
        replacement.Text = "Replacement (part variation):";
        // 
        // L_EditStatus
        // 
        L_EditStatus.Dock = DockStyle.Bottom;
        L_EditStatus.Location = new Point(3, 430);
        L_EditStatus.Name = "L_EditStatus";
        L_EditStatus.Size = new Size(525, 43);
        L_EditStatus.TabIndex = 16;
        // 
        // CB_Item
        // 
        CB_Item.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        CB_Item.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        CB_Item.AutoCompleteSource = AutoCompleteSource.ListItems;
        CB_Item.DrawMode = DrawMode.OwnerDrawFixed;
        CB_Item.DropDownStyle = ComboBoxStyle.DropDownList;
        CB_Item.DropDownWidth = 420;
        CB_Item.ItemHeight = 30;
        CB_Item.Location = new Point(14, 160);
        CB_Item.Margin = new Padding(3, 4, 3, 4);
        CB_Item.Name = "CB_Item";
        CB_Item.Size = new Size(367, 36);
        CB_Item.TabIndex = 4;
        CB_Item.DrawItem += CB_Item_DrawItem;
        CB_Item.SelectedIndexChanged += Placement_Changed;
        // 
        // x
        // 
        x.Location = new Point(14, 221);
        x.Name = "x";
        x.Size = new Size(27, 27);
        x.TabIndex = 5;
        x.Text = "X:";
        // 
        // y
        // 
        y.Location = new Point(139, 221);
        y.Name = "y";
        y.Size = new Size(27, 27);
        y.TabIndex = 6;
        y.Text = "Y:";
        // 
        // z
        // 
        z.Location = new Point(265, 221);
        z.Name = "z";
        z.Size = new Size(27, 27);
        z.TabIndex = 7;
        z.Text = "Z:";
        // 
        // NUD_X
        // 
        NUD_X.Location = new Point(14, 248);
        NUD_X.Margin = new Padding(3, 4, 3, 4);
        NUD_X.Maximum = new decimal(new int[] { 2047, 0, 0, 0 });
        NUD_X.Name = "NUD_X";
        NUD_X.Size = new Size(112, 27);
        NUD_X.TabIndex = 8;
        NUD_X.ValueChanged += Placement_Changed;
        // 
        // NUD_Y
        // 
        NUD_Y.Location = new Point(139, 248);
        NUD_Y.Margin = new Padding(3, 4, 3, 4);
        NUD_Y.Maximum = new decimal(new int[] { 127, 0, 0, 0 });
        NUD_Y.Name = "NUD_Y";
        NUD_Y.Size = new Size(112, 27);
        NUD_Y.TabIndex = 9;
        NUD_Y.ValueChanged += Placement_Changed;
        // 
        // NUD_Z
        // 
        NUD_Z.Location = new Point(265, 248);
        NUD_Z.Margin = new Padding(3, 4, 3, 4);
        NUD_Z.Maximum = new decimal(new int[] { 2047, 0, 0, 0 });
        NUD_Z.Name = "NUD_Z";
        NUD_Z.Size = new Size(112, 27);
        NUD_Z.TabIndex = 10;
        NUD_Z.ValueChanged += Placement_Changed;
        // 
        // direction
        // 
        direction.Location = new Point(14, 296);
        direction.Name = "direction";
        direction.Size = new Size(137, 27);
        direction.TabIndex = 11;
        direction.Text = "Direction:";
        // 
        // CB_Direction
        // 
        CB_Direction.DropDownStyle = ComboBoxStyle.DropDownList;
        CB_Direction.Items.AddRange(new object[] { "0", "1", "2", "3" });
        CB_Direction.Location = new Point(14, 325);
        CB_Direction.Margin = new Padding(3, 4, 3, 4);
        CB_Direction.Name = "CB_Direction";
        CB_Direction.Size = new Size(182, 28);
        CB_Direction.TabIndex = 12;
        CB_Direction.SelectedIndexChanged += Placement_Changed;
        // 
        // B_Set
        // 
        B_Set.Location = new Point(263, 320);
        B_Set.Margin = new Padding(3, 4, 3, 4);
        B_Set.Name = "B_Set";
        B_Set.Size = new Size(114, 40);
        B_Set.TabIndex = 13;
        B_Set.Text = "Set";
        B_Set.Click += B_Set_Click;
        // 
        // B_Undo
        // 
        B_Undo.Location = new Point(14, 376);
        B_Undo.Margin = new Padding(3, 4, 3, 4);
        B_Undo.Name = "B_Undo";
        B_Undo.Size = new Size(114, 40);
        B_Undo.TabIndex = 14;
        B_Undo.Text = "Undo";
        B_Undo.Click += B_Undo_Click;
        // 
        // B_Redo
        // 
        B_Redo.Location = new Point(139, 376);
        B_Redo.Margin = new Padding(3, 4, 3, 4);
        B_Redo.Name = "B_Redo";
        B_Redo.Size = new Size(114, 40);
        B_Redo.TabIndex = 15;
        B_Redo.Text = "Redo";
        B_Redo.Click += B_Redo_Click;
        // 
        // L_Coordinates
        // 
        L_Coordinates.Dock = DockStyle.Bottom;
        L_Coordinates.Location = new Point(7, 1187);
        L_Coordinates.Name = "L_Coordinates";
        L_Coordinates.Size = new Size(1531, 37);
        L_Coordinates.TabIndex = 2;
        L_Coordinates.Text = "Click to select. Right-click to position. Set applies changes.";
        // 
        // MapEditor
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(split);
        Controls.Add(L_Coordinates);
        Margin = new Padding(3, 4, 3, 4);
        Name = "MapEditor";
        Padding = new Padding(7, 8, 7, 8);
        Size = new Size(1545, 1232);
        Load += View_Changed;
        filters.ResumeLayout(false);
        filters.PerformLayout();
        ((ISupportInitialize)NUD_Height).EndInit();
        split.Panel1.ResumeLayout(false);
        split.Panel2.ResumeLayout(false);
        ((ISupportInitialize)split).EndInit();
        split.ResumeLayout(false);
        ((ISupportInitialize)PB_Map).EndInit();
        details.ResumeLayout(false);
        GB_Details.ResumeLayout(false);
        ((ISupportInitialize)PB_Item).EndInit();
        ((ISupportInitialize)NUD_X).EndInit();
        ((ISupportInitialize)NUD_Y).EndInit();
        ((ISupportInitialize)NUD_Z).EndInit();
        ResumeLayout(false);
    }

    private ComboBox CB_Area = null!;
    private ComboBox CB_Chunk = null!;
    private NumericUpDown NUD_Height = null!;
    private CheckBox CHK_AllHeights = null!;
    private TextBox TB_Search = null!;
    private ListBox LB_Parts = null!;
    private PictureBox PB_Map = null!;
    private PictureBox PB_Item = null!;
    private GroupBox GB_Details = null!;
    private Label L_Item = null!;
    private Label L_Details = null!;
    private Label L_Count = null!;
    private Label L_EditStatus = null!;
    private Label L_Coordinates = null!;
    private ComboBox CB_Item = null!;
    private NumericUpDown NUD_X = null!;
    private NumericUpDown NUD_Y = null!;
    private NumericUpDown NUD_Z = null!;
    private ComboBox CB_Direction = null!;
    private Button B_Set = null!;
    private Button B_Undo = null!;
    private Button B_Redo = null!;
    private Panel filters;
    private Label area;
    private Label chunk;
    private Label height;
    private Label search;
    private SplitContainer split;
    private Panel details;
    private Label replacement;
    private Label x;
    private Label y;
    private Label z;
    private Label direction;
    private CheckBox checkBox1;
    private Label interior;
    private ComboBox CB_Interior;
    private Button btnJumpToInteriors;
}