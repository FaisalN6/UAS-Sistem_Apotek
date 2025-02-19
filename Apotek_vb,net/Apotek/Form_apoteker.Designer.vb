<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_apoteker
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
        Me.txtcari_transaksi = New System.Windows.Forms.TextBox()
        Me.dg_transaksi = New System.Windows.Forms.DataGridView()
        Me.dg_obat = New System.Windows.Forms.DataGridView()
        Me.btn_caritransaksi = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_cariobat = New System.Windows.Forms.Button()
        Me.txt_cariobat = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dg_transaksi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg_obat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtcari_transaksi
        '
        Me.txtcari_transaksi.Location = New System.Drawing.Point(4, 63)
        Me.txtcari_transaksi.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtcari_transaksi.Name = "txtcari_transaksi"
        Me.txtcari_transaksi.Size = New System.Drawing.Size(208, 20)
        Me.txtcari_transaksi.TabIndex = 0
        '
        'dg_transaksi
        '
        Me.dg_transaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_transaksi.Location = New System.Drawing.Point(4, 94)
        Me.dg_transaksi.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dg_transaksi.Name = "dg_transaksi"
        Me.dg_transaksi.RowHeadersWidth = 62
        Me.dg_transaksi.RowTemplate.Height = 28
        Me.dg_transaksi.Size = New System.Drawing.Size(443, 360)
        Me.dg_transaksi.TabIndex = 1
        '
        'dg_obat
        '
        Me.dg_obat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_obat.Location = New System.Drawing.Point(15, 91)
        Me.dg_obat.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dg_obat.Name = "dg_obat"
        Me.dg_obat.RowHeadersWidth = 62
        Me.dg_obat.RowTemplate.Height = 28
        Me.dg_obat.Size = New System.Drawing.Size(463, 363)
        Me.dg_obat.TabIndex = 2
        '
        'btn_caritransaksi
        '
        Me.btn_caritransaksi.Location = New System.Drawing.Point(216, 63)
        Me.btn_caritransaksi.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_caritransaksi.Name = "btn_caritransaksi"
        Me.btn_caritransaksi.Size = New System.Drawing.Size(122, 20)
        Me.btn_caritransaksi.TabIndex = 3
        Me.btn_caritransaksi.Text = "Cari"
        Me.btn_caritransaksi.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.btn_cariobat)
        Me.GroupBox1.Controls.Add(Me.txt_cariobat)
        Me.GroupBox1.Controls.Add(Me.dg_obat)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 8)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(500, 469)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Obat"
        '
        'btn_cariobat
        '
        Me.btn_cariobat.Location = New System.Drawing.Point(235, 62)
        Me.btn_cariobat.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_cariobat.Name = "btn_cariobat"
        Me.btn_cariobat.Size = New System.Drawing.Size(177, 20)
        Me.btn_cariobat.TabIndex = 5
        Me.btn_cariobat.Text = "Cari"
        Me.btn_cariobat.UseVisualStyleBackColor = True
        '
        'txt_cariobat
        '
        Me.txt_cariobat.Location = New System.Drawing.Point(15, 62)
        Me.txt_cariobat.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_cariobat.Name = "txt_cariobat"
        Me.txt_cariobat.Size = New System.Drawing.Size(207, 20)
        Me.txt_cariobat.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Panel2)
        Me.GroupBox2.Controls.Add(Me.txtcari_transaksi)
        Me.GroupBox2.Controls.Add(Me.btn_caritransaksi)
        Me.GroupBox2.Controls.Add(Me.dg_transaksi)
        Me.GroupBox2.Location = New System.Drawing.Point(558, 8)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(462, 469)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Transaksi"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Blue
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 18)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(500, 39)
        Me.Panel1.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Blue
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(-19, 18)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(500, 40)
        Me.Panel2.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(179, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "List Obat"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(184, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 31)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "List Obat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(148, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(238, 31)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Pemesanan Obat"
        '
        'Form_apoteker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1047, 498)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form_apoteker"
        Me.Text = "Form_apoteker"
        CType(Me.dg_transaksi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_obat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtcari_transaksi As TextBox
    Friend WithEvents dg_transaksi As DataGridView
    Friend WithEvents dg_obat As DataGridView
    Friend WithEvents btn_caritransaksi As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_cariobat As TextBox
    Friend WithEvents btn_cariobat As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
End Class
