<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.search = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.room = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.female = New System.Windows.Forms.RadioButton()
        Me.male = New System.Windows.Forms.RadioButton()
        Me.idcard = New System.Windows.Forms.TextBox()
        Me.fullname1 = New System.Windows.Forms.TextBox()
        Me.ampareid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.idtxt = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.bn = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.count = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.movefirst = New System.Windows.Forms.ToolStripButton()
        Me.previousmove = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.record = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.nextmove = New System.Windows.Forms.ToolStripButton()
        Me.lastmove = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.tsedit = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.bn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bn.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Image = Global.Ampare_Pichaya.My.Resources.Resources._1345539813_gnome_searchtool
        Me.Button1.Location = New System.Drawing.Point(121, 15)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(32, 32)
        Me.Button1.TabIndex = 2
        Me.Button1.UseVisualStyleBackColor = True
        '
        'search
        '
        Me.search.Location = New System.Drawing.Point(159, 22)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(244, 20)
        Me.search.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.Image = Global.Ampare_Pichaya.My.Resources.Resources.filesave_32
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(409, 8)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(106, 47)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "ตกลง"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Image = Global.Ampare_Pichaya.My.Resources.Resources.clear_icon
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(521, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(108, 43)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "ยกเลิก"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(31, 66)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(597, 245)
        Me.TabControl1.TabIndex = 6
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.DateTimePicker1)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.room)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.female)
        Me.TabPage1.Controls.Add(Me.male)
        Me.TabPage1.Controls.Add(Me.idcard)
        Me.TabPage1.Controls.Add(Me.fullname1)
        Me.TabPage1.Controls.Add(Me.ampareid)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.idtxt)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(589, 219)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "ข้อมูลนักเรียน"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(311, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "วันเกิด"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(314, 75)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.BlueViolet
        Me.Label6.Location = New System.Drawing.Point(307, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(261, 39)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Unfinish Project"
        '
        'room
        '
        Me.room.Location = New System.Drawing.Point(173, 75)
        Me.room.Name = "room"
        Me.room.Size = New System.Drawing.Size(100, 20)
        Me.room.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(189, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Room"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "ID Card"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(189, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "ชื่อ-นามสกุล"
        '
        'female
        '
        Me.female.AutoSize = True
        Me.female.Location = New System.Drawing.Point(84, 113)
        Me.female.Name = "female"
        Me.female.Size = New System.Drawing.Size(46, 17)
        Me.female.TabIndex = 6
        Me.female.TabStop = True
        Me.female.Text = "หญิง"
        Me.female.UseVisualStyleBackColor = True
        '
        'male
        '
        Me.male.AutoSize = True
        Me.male.Location = New System.Drawing.Point(23, 113)
        Me.male.Name = "male"
        Me.male.Size = New System.Drawing.Size(44, 17)
        Me.male.TabIndex = 5
        Me.male.TabStop = True
        Me.male.Text = "ชาย"
        Me.male.UseVisualStyleBackColor = True
        '
        'idcard
        '
        Me.idcard.Location = New System.Drawing.Point(23, 75)
        Me.idcard.Name = "idcard"
        Me.idcard.Size = New System.Drawing.Size(144, 20)
        Me.idcard.TabIndex = 4
        '
        'fullname1
        '
        Me.fullname1.Location = New System.Drawing.Point(227, 28)
        Me.fullname1.Name = "fullname1"
        Me.fullname1.Size = New System.Drawing.Size(341, 20)
        Me.fullname1.TabIndex = 3
        '
        'ampareid
        '
        Me.ampareid.Location = New System.Drawing.Point(109, 28)
        Me.ampareid.Name = "ampareid"
        Me.ampareid.Size = New System.Drawing.Size(100, 20)
        Me.ampareid.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID"
        '
        'idtxt
        '
        Me.idtxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.idtxt.Location = New System.Drawing.Point(30, 28)
        Me.idtxt.Name = "idtxt"
        Me.idtxt.Size = New System.Drawing.Size(50, 20)
        Me.idtxt.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.RichTextBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(589, 219)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "ประวัติ"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Location = New System.Drawing.Point(3, 3)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(583, 213)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'bn
        '
        Me.bn.AddNewItem = Me.count
        Me.bn.CountItem = Me.count
        Me.bn.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.bn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bn.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.movefirst, Me.previousmove, Me.BindingNavigatorSeparator, Me.record, Me.count, Me.BindingNavigatorSeparator1, Me.nextmove, Me.lastmove, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem})
        Me.bn.Location = New System.Drawing.Point(0, 325)
        Me.bn.MoveFirstItem = Me.movefirst
        Me.bn.MoveLastItem = Me.lastmove
        Me.bn.MoveNextItem = Me.nextmove
        Me.bn.MovePreviousItem = Me.previousmove
        Me.bn.Name = "bn"
        Me.bn.PositionItem = Me.record
        Me.bn.Size = New System.Drawing.Size(658, 25)
        Me.bn.TabIndex = 7
        Me.bn.Text = "BindingNavigator1"
        '
        'count
        '
        Me.count.Name = "count"
        Me.count.Size = New System.Drawing.Size(35, 22)
        Me.count.Text = "of {0}"
        Me.count.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'movefirst
        '
        Me.movefirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.movefirst.Image = CType(resources.GetObject("movefirst.Image"), System.Drawing.Image)
        Me.movefirst.Name = "movefirst"
        Me.movefirst.RightToLeftAutoMirrorImage = True
        Me.movefirst.Size = New System.Drawing.Size(23, 22)
        Me.movefirst.Text = "Move first"
        '
        'previousmove
        '
        Me.previousmove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.previousmove.Image = CType(resources.GetObject("previousmove.Image"), System.Drawing.Image)
        Me.previousmove.Name = "previousmove"
        Me.previousmove.RightToLeftAutoMirrorImage = True
        Me.previousmove.Size = New System.Drawing.Size(23, 22)
        Me.previousmove.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'record
        '
        Me.record.AccessibleName = "Position"
        Me.record.AutoSize = False
        Me.record.Name = "record"
        Me.record.Size = New System.Drawing.Size(50, 23)
        Me.record.Text = "0"
        Me.record.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'nextmove
        '
        Me.nextmove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.nextmove.Image = CType(resources.GetObject("nextmove.Image"), System.Drawing.Image)
        Me.nextmove.Name = "nextmove"
        Me.nextmove.RightToLeftAutoMirrorImage = True
        Me.nextmove.Size = New System.Drawing.Size(23, 22)
        Me.nextmove.Text = "Move next"
        '
        'lastmove
        '
        Me.lastmove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.lastmove.Image = CType(resources.GetObject("lastmove.Image"), System.Drawing.Image)
        Me.lastmove.Name = "lastmove"
        Me.lastmove.RightToLeftAutoMirrorImage = True
        Me.lastmove.Size = New System.Drawing.Size(23, 22)
        Me.lastmove.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'tsedit
        '
        Me.tsedit.Location = New System.Drawing.Point(31, 20)
        Me.tsedit.Name = "tsedit"
        Me.tsedit.Size = New System.Drawing.Size(75, 23)
        Me.tsedit.TabIndex = 8
        Me.tsedit.Text = "แก้ไขข้อมูล"
        Me.tsedit.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BlueViolet
        Me.ClientSize = New System.Drawing.Size(658, 350)
        Me.Controls.Add(Me.tsedit)
        Me.Controls.Add(Me.bn)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.search)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.Text = "แก้ไขข้อมูลนักเรียน"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.bn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bn.ResumeLayout(False)
        Me.bn.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents search As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents female As System.Windows.Forms.RadioButton
    Friend WithEvents male As System.Windows.Forms.RadioButton
    Friend WithEvents idcard As System.Windows.Forms.TextBox
    Friend WithEvents fullname1 As System.Windows.Forms.TextBox
    Friend WithEvents ampareid As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents idtxt As System.Windows.Forms.TextBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents room As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents bn As System.Windows.Forms.BindingNavigator
    Friend WithEvents count As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents movefirst As System.Windows.Forms.ToolStripButton
    Friend WithEvents previousmove As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents record As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents nextmove As System.Windows.Forms.ToolStripButton
    Friend WithEvents lastmove As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents tsedit As System.Windows.Forms.Button
End Class
