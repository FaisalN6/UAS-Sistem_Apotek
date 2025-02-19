<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class transaksi_form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lbl_qty = New System.Windows.Forms.Label()
        Me.lbl_item = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Guna2GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btm_simpan = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dg_transaksi = New System.Windows.Forms.DataGridView()
        Me.nota = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kd_obat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_obat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_stock = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btn_kembali = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.txt_jumlah = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_harga = New System.Windows.Forms.TextBox()
        Me.txt_kdobat = New System.Windows.Forms.TextBox()
        Me.txt_namaobat = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_kdsupllier = New System.Windows.Forms.TextBox()
        Me.txt_kdkategori = New System.Windows.Forms.TextBox()
        Me.txt_nota = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Guna2GroupBox2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dg_transaksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.GrayText
        Me.Panel4.Controls.Add(Me.lbl_qty)
        Me.Panel4.Controls.Add(Me.lbl_item)
        Me.Panel4.Controls.Add(Me.Label13)
        Me.Panel4.Controls.Add(Me.Label12)
        Me.Panel4.Location = New System.Drawing.Point(366, 445)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(278, 103)
        Me.Panel4.TabIndex = 3
        '
        'lbl_qty
        '
        Me.lbl_qty.AutoSize = True
        Me.lbl_qty.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_qty.Location = New System.Drawing.Point(177, 62)
        Me.lbl_qty.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_qty.Name = "lbl_qty"
        Me.lbl_qty.Size = New System.Drawing.Size(27, 29)
        Me.lbl_qty.TabIndex = 19
        Me.lbl_qty.Text = "0"
        '
        'lbl_item
        '
        Me.lbl_item.AutoSize = True
        Me.lbl_item.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_item.Location = New System.Drawing.Point(177, 15)
        Me.lbl_item.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_item.Name = "lbl_item"
        Me.lbl_item.Size = New System.Drawing.Size(27, 29)
        Me.lbl_item.TabIndex = 2
        Me.lbl_item.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(4, 55)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(114, 29)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "Total qty"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(4, 12)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(130, 29)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Total Item"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.GrayText
        Me.Panel3.Controls.Add(Me.txt_total)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Location = New System.Drawing.Point(652, 445)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(310, 103)
        Me.Panel3.TabIndex = 2
        '
        'txt_total
        '
        Me.txt_total.BackColor = System.Drawing.SystemColors.GrayText
        Me.txt_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total.Location = New System.Drawing.Point(72, 48)
        Me.txt_total.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(218, 44)
        Me.txt_total.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(15, 51)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 33)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Rp."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(4, 6)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(114, 33)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "TOTAL"
        '
        'Guna2GroupBox2
        '
        Me.Guna2GroupBox2.Controls.Add(Me.btm_simpan)
        Me.Guna2GroupBox2.Controls.Add(Me.Panel4)
        Me.Guna2GroupBox2.Controls.Add(Me.Panel3)
        Me.Guna2GroupBox2.Controls.Add(Me.Panel2)
        Me.Guna2GroupBox2.Controls.Add(Me.dg_transaksi)
        Me.Guna2GroupBox2.Location = New System.Drawing.Point(102, 345)
        Me.Guna2GroupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Guna2GroupBox2.Name = "Guna2GroupBox2"
        Me.Guna2GroupBox2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Guna2GroupBox2.Size = New System.Drawing.Size(1257, 568)
        Me.Guna2GroupBox2.TabIndex = 20
        Me.Guna2GroupBox2.TabStop = False
        '
        'btm_simpan
        '
        Me.btm_simpan.BackColor = System.Drawing.Color.Green
        Me.btm_simpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btm_simpan.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btm_simpan.Location = New System.Drawing.Point(972, 445)
        Me.btm_simpan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btm_simpan.Name = "btm_simpan"
        Me.btm_simpan.Size = New System.Drawing.Size(276, 103)
        Me.btm_simpan.TabIndex = 19
        Me.btm_simpan.Text = "Simpan"
        Me.btm_simpan.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Blue
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Location = New System.Drawing.Point(0, 22)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1257, 55)
        Me.Panel2.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(495, 0)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(210, 47)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Transaksi"
        '
        'dg_transaksi
        '
        Me.dg_transaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_transaksi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nota, Me.kd_obat, Me.nama_obat, Me.harga, Me.jumlah, Me.total})
        Me.dg_transaksi.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dg_transaksi.Location = New System.Drawing.Point(15, 85)
        Me.dg_transaksi.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dg_transaksi.Name = "dg_transaksi"
        Me.dg_transaksi.RowHeadersWidth = 62
        Me.dg_transaksi.Size = New System.Drawing.Size(1233, 351)
        Me.dg_transaksi.TabIndex = 0
        '
        'nota
        '
        Me.nota.HeaderText = "Kode Transaksi"
        Me.nota.MinimumWidth = 8
        Me.nota.Name = "nota"
        Me.nota.Width = 150
        '
        'kd_obat
        '
        Me.kd_obat.HeaderText = "kode Obat"
        Me.kd_obat.MinimumWidth = 8
        Me.kd_obat.Name = "kd_obat"
        Me.kd_obat.Width = 150
        '
        'nama_obat
        '
        Me.nama_obat.HeaderText = "Nama Obat"
        Me.nama_obat.MinimumWidth = 8
        Me.nama_obat.Name = "nama_obat"
        Me.nama_obat.Width = 150
        '
        'harga
        '
        Me.harga.HeaderText = "Harga Obat"
        Me.harga.MinimumWidth = 8
        Me.harga.Name = "harga"
        Me.harga.Width = 150
        '
        'jumlah
        '
        Me.jumlah.HeaderText = "jumlah"
        Me.jumlah.MinimumWidth = 8
        Me.jumlah.Name = "jumlah"
        Me.jumlah.Width = 150
        '
        'total
        '
        Me.total.HeaderText = "total"
        Me.total.MinimumWidth = 8
        Me.total.Name = "total"
        Me.total.Width = 150
        '
        'btn_simpan
        '
        Me.btn_simpan.BackColor = System.Drawing.Color.Green
        Me.btn_simpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_simpan.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_simpan.Location = New System.Drawing.Point(1074, 789)
        Me.btn_simpan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(276, 114)
        Me.btn_simpan.TabIndex = 21
        Me.btn_simpan.Text = "Simpan"
        Me.btn_simpan.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(495, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(210, 47)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Transaksi"
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Controls.Add(Me.txt_stock)
        Me.Guna2GroupBox1.Controls.Add(Me.Label14)
        Me.Guna2GroupBox1.Controls.Add(Me.btn_kembali)
        Me.Guna2GroupBox1.Controls.Add(Me.btn_cancel)
        Me.Guna2GroupBox1.Controls.Add(Me.btn_insert)
        Me.Guna2GroupBox1.Controls.Add(Me.txt_jumlah)
        Me.Guna2GroupBox1.Controls.Add(Me.Label8)
        Me.Guna2GroupBox1.Controls.Add(Me.txt_harga)
        Me.Guna2GroupBox1.Controls.Add(Me.txt_kdobat)
        Me.Guna2GroupBox1.Controls.Add(Me.txt_namaobat)
        Me.Guna2GroupBox1.Controls.Add(Me.Label7)
        Me.Guna2GroupBox1.Controls.Add(Me.Label6)
        Me.Guna2GroupBox1.Controls.Add(Me.Label5)
        Me.Guna2GroupBox1.Controls.Add(Me.txt_kdsupllier)
        Me.Guna2GroupBox1.Controls.Add(Me.txt_kdkategori)
        Me.Guna2GroupBox1.Controls.Add(Me.txt_nota)
        Me.Guna2GroupBox1.Controls.Add(Me.Label4)
        Me.Guna2GroupBox1.Controls.Add(Me.Label3)
        Me.Guna2GroupBox1.Controls.Add(Me.Label2)
        Me.Guna2GroupBox1.Controls.Add(Me.Panel1)
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(102, 8)
        Me.Guna2GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(1257, 268)
        Me.Guna2GroupBox1.TabIndex = 19
        Me.Guna2GroupBox1.TabStop = False
        '
        'txt_stock
        '
        Me.txt_stock.Location = New System.Drawing.Point(1056, 97)
        Me.txt_stock.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_stock.Name = "txt_stock"
        Me.txt_stock.Size = New System.Drawing.Size(190, 26)
        Me.txt_stock.TabIndex = 19
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(860, 92)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(74, 29)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "stock"
        '
        'btn_kembali
        '
        Me.btn_kembali.BackColor = System.Drawing.Color.Blue
        Me.btn_kembali.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_kembali.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_kembali.Location = New System.Drawing.Point(1132, 200)
        Me.btn_kembali.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_kembali.Name = "btn_kembali"
        Me.btn_kembali.Size = New System.Drawing.Size(116, 49)
        Me.btn_kembali.TabIndex = 17
        Me.btn_kembali.Text = "Kembali"
        Me.btn_kembali.UseVisualStyleBackColor = False
        '
        'btn_cancel
        '
        Me.btn_cancel.BackColor = System.Drawing.Color.Red
        Me.btn_cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_cancel.Location = New System.Drawing.Point(866, 198)
        Me.btn_cancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(122, 49)
        Me.btn_cancel.TabIndex = 16
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'btn_insert
        '
        Me.btn_insert.BackColor = System.Drawing.Color.Green
        Me.btn_insert.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_insert.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_insert.Location = New System.Drawing.Point(996, 200)
        Me.btn_insert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(126, 49)
        Me.btn_insert.TabIndex = 15
        Me.btn_insert.Text = "Insert"
        Me.btn_insert.UseVisualStyleBackColor = False
        '
        'txt_jumlah
        '
        Me.txt_jumlah.Location = New System.Drawing.Point(1056, 145)
        Me.txt_jumlah.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_jumlah.Name = "txt_jumlah"
        Me.txt_jumlah.Size = New System.Drawing.Size(190, 26)
        Me.txt_jumlah.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(860, 145)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(159, 29)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Jumlah Obat"
        '
        'txt_harga
        '
        Me.txt_harga.Location = New System.Drawing.Point(652, 202)
        Me.txt_harga.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_harga.Name = "txt_harga"
        Me.txt_harga.Size = New System.Drawing.Size(190, 26)
        Me.txt_harga.TabIndex = 12
        '
        'txt_kdobat
        '
        Me.txt_kdobat.Location = New System.Drawing.Point(652, 149)
        Me.txt_kdobat.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_kdobat.Name = "txt_kdobat"
        Me.txt_kdobat.Size = New System.Drawing.Size(190, 26)
        Me.txt_kdobat.TabIndex = 11
        '
        'txt_namaobat
        '
        Me.txt_namaobat.Location = New System.Drawing.Point(652, 97)
        Me.txt_namaobat.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_namaobat.Name = "txt_namaobat"
        Me.txt_namaobat.Size = New System.Drawing.Size(190, 26)
        Me.txt_namaobat.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(462, 197)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(173, 29)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Harga Barang"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(462, 95)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(144, 29)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Nama Obat"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(462, 148)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 29)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "kode Obat"
        '
        'txt_kdsupllier
        '
        Me.txt_kdsupllier.Location = New System.Drawing.Point(216, 200)
        Me.txt_kdsupllier.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_kdsupllier.Name = "txt_kdsupllier"
        Me.txt_kdsupllier.Size = New System.Drawing.Size(190, 26)
        Me.txt_kdsupllier.TabIndex = 6
        '
        'txt_kdkategori
        '
        Me.txt_kdkategori.Location = New System.Drawing.Point(216, 148)
        Me.txt_kdkategori.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_kdkategori.Name = "txt_kdkategori"
        Me.txt_kdkategori.Size = New System.Drawing.Size(190, 26)
        Me.txt_kdkategori.TabIndex = 5
        '
        'txt_nota
        '
        Me.txt_nota.Location = New System.Drawing.Point(216, 95)
        Me.txt_nota.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_nota.Name = "txt_nota"
        Me.txt_nota.Size = New System.Drawing.Size(190, 26)
        Me.txt_nota.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 200)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(181, 29)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Kode Supplier"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 145)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(181, 29)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Kode Kategori"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 92)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(196, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kode Transaksi"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Blue
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 18)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1257, 55)
        Me.Panel1.TabIndex = 0
        '
        'transaksi_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1461, 931)
        Me.Controls.Add(Me.Guna2GroupBox2)
        Me.Controls.Add(Me.btn_simpan)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "transaksi_form"
        Me.Text = "transaksi_form"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Guna2GroupBox2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dg_transaksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lbl_qty As Label
    Friend WithEvents lbl_item As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txt_total As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Guna2GroupBox2 As GroupBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents dg_transaksi As DataGridView
    Friend WithEvents btn_simpan As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2GroupBox1 As GroupBox
    Friend WithEvents btn_kembali As Button
    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_insert As Button
    Friend WithEvents txt_jumlah As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_harga As TextBox
    Friend WithEvents txt_kdobat As TextBox
    Friend WithEvents txt_namaobat As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_kdsupllier As TextBox
    Friend WithEvents txt_kdkategori As TextBox
    Friend WithEvents txt_nota As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btm_simpan As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents txt_stock As TextBox
    Friend WithEvents nota As DataGridViewTextBoxColumn
    Friend WithEvents kd_obat As DataGridViewTextBoxColumn
    Friend WithEvents nama_obat As DataGridViewTextBoxColumn
    Friend WithEvents harga As DataGridViewTextBoxColumn
    Friend WithEvents jumlah As DataGridViewTextBoxColumn
    Friend WithEvents total As DataGridViewTextBoxColumn
End Class
