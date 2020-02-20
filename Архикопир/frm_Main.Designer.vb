<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Globall
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Globall))
        Me.btn_RefAll = New System.Windows.Forms.Button()
        Me.btn_RefOne = New System.Windows.Forms.Button()
        Me.btn_Add = New System.Windows.Forms.Button()
        Me.btn_Conv = New System.Windows.Forms.Button()
        Me.btn_Copy = New System.Windows.Forms.Button()
        Me.btn_Del = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_Exit = New System.Windows.Forms.Button()
        Me.lbx_Data = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.НастройкиToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ОткрытьВыделенныеПапкиToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СохранитьПутиToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ПерезагрузитьПутиToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ОткрытьФайлПутейToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ВыйтиToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ОткрытьЛогToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ПутьКЛогфайлуToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.УстановитьСтандартныйToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ВвестиToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ОткрытьЛогВыделенногоToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ОткрытьЛогПрограммыToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.УдалитьЛогПрограммыToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СправкаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ОПрограммеToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СправкаToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_RefAll
        '
        Me.btn_RefAll.Location = New System.Drawing.Point(6, 63)
        Me.btn_RefAll.Name = "btn_RefAll"
        Me.btn_RefAll.Size = New System.Drawing.Size(150, 35)
        Me.btn_RefAll.TabIndex = 0
        Me.btn_RefAll.Text = "Обновить все"
        Me.btn_RefAll.UseVisualStyleBackColor = True
        '
        'btn_RefOne
        '
        Me.btn_RefOne.Location = New System.Drawing.Point(6, 22)
        Me.btn_RefOne.Name = "btn_RefOne"
        Me.btn_RefOne.Size = New System.Drawing.Size(150, 35)
        Me.btn_RefOne.TabIndex = 1
        Me.btn_RefOne.Text = "Обновить выделенное"
        Me.btn_RefOne.UseVisualStyleBackColor = True
        '
        'btn_Add
        '
        Me.btn_Add.Location = New System.Drawing.Point(6, 23)
        Me.btn_Add.Name = "btn_Add"
        Me.btn_Add.Size = New System.Drawing.Size(150, 35)
        Me.btn_Add.TabIndex = 1
        Me.btn_Add.Text = "Добавить"
        Me.btn_Add.UseVisualStyleBackColor = True
        '
        'btn_Conv
        '
        Me.btn_Conv.Location = New System.Drawing.Point(6, 64)
        Me.btn_Conv.Name = "btn_Conv"
        Me.btn_Conv.Size = New System.Drawing.Size(150, 35)
        Me.btn_Conv.TabIndex = 1
        Me.btn_Conv.Text = "Изменить выделенное"
        Me.btn_Conv.UseVisualStyleBackColor = True
        '
        'btn_Copy
        '
        Me.btn_Copy.Location = New System.Drawing.Point(6, 105)
        Me.btn_Copy.Name = "btn_Copy"
        Me.btn_Copy.Size = New System.Drawing.Size(150, 35)
        Me.btn_Copy.TabIndex = 1
        Me.btn_Copy.Text = "Копировать выделенное"
        Me.btn_Copy.UseVisualStyleBackColor = True
        '
        'btn_Del
        '
        Me.btn_Del.Location = New System.Drawing.Point(6, 146)
        Me.btn_Del.Name = "btn_Del"
        Me.btn_Del.Size = New System.Drawing.Size(150, 35)
        Me.btn_Del.TabIndex = 1
        Me.btn_Del.Text = "Удалить выделенное"
        Me.btn_Del.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btn_Del)
        Me.GroupBox1.Controls.Add(Me.btn_Add)
        Me.GroupBox1.Controls.Add(Me.btn_Conv)
        Me.GroupBox1.Controls.Add(Me.btn_Copy)
        Me.GroupBox1.Location = New System.Drawing.Point(777, 131)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(165, 189)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Панель изменения"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.btn_RefOne)
        Me.GroupBox2.Controls.Add(Me.btn_RefAll)
        Me.GroupBox2.Location = New System.Drawing.Point(777, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(165, 106)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Панель обновления"
        '
        'btn_Exit
        '
        Me.btn_Exit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Exit.Location = New System.Drawing.Point(783, 339)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.Size = New System.Drawing.Size(150, 35)
        Me.btn_Exit.TabIndex = 1
        Me.btn_Exit.Text = "Закрыть"
        Me.btn_Exit.UseVisualStyleBackColor = True
        '
        'lbx_Data
        '
        Me.lbx_Data.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lbx_Data.FormattingEnabled = True
        Me.lbx_Data.HorizontalScrollbar = True
        Me.lbx_Data.ItemHeight = 16
        Me.lbx_Data.Location = New System.Drawing.Point(12, 34)
        Me.lbx_Data.Name = "lbx_Data"
        Me.lbx_Data.Size = New System.Drawing.Size(759, 340)
        Me.lbx_Data.TabIndex = 3
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.НастройкиToolStripMenuItem, Me.ОткрытьЛогToolStripMenuItem, Me.СправкаToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(954, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'НастройкиToolStripMenuItem
        '
        Me.НастройкиToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ОткрытьВыделенныеПапкиToolStripMenuItem, Me.СохранитьПутиToolStripMenuItem, Me.ПерезагрузитьПутиToolStripMenuItem, Me.ОткрытьФайлПутейToolStripMenuItem, Me.ВыйтиToolStripMenuItem})
        Me.НастройкиToolStripMenuItem.Name = "НастройкиToolStripMenuItem"
        Me.НастройкиToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.НастройкиToolStripMenuItem.Text = "Настройки"
        '
        'ОткрытьВыделенныеПапкиToolStripMenuItem
        '
        Me.ОткрытьВыделенныеПапкиToolStripMenuItem.Name = "ОткрытьВыделенныеПапкиToolStripMenuItem"
        Me.ОткрытьВыделенныеПапкиToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
        Me.ОткрытьВыделенныеПапкиToolStripMenuItem.Text = "Открыть выделенные папки"
        '
        'СохранитьПутиToolStripMenuItem
        '
        Me.СохранитьПутиToolStripMenuItem.Name = "СохранитьПутиToolStripMenuItem"
        Me.СохранитьПутиToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
        Me.СохранитьПутиToolStripMenuItem.Text = "Сохранить пути"
        '
        'ПерезагрузитьПутиToolStripMenuItem
        '
        Me.ПерезагрузитьПутиToolStripMenuItem.Name = "ПерезагрузитьПутиToolStripMenuItem"
        Me.ПерезагрузитьПутиToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
        Me.ПерезагрузитьПутиToolStripMenuItem.Text = "Перезагрузить пути"
        '
        'ОткрытьФайлПутейToolStripMenuItem
        '
        Me.ОткрытьФайлПутейToolStripMenuItem.Name = "ОткрытьФайлПутейToolStripMenuItem"
        Me.ОткрытьФайлПутейToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
        Me.ОткрытьФайлПутейToolStripMenuItem.Text = "Открыть файл путей"
        '
        'ВыйтиToolStripMenuItem
        '
        Me.ВыйтиToolStripMenuItem.Name = "ВыйтиToolStripMenuItem"
        Me.ВыйтиToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
        Me.ВыйтиToolStripMenuItem.Text = "Выйти"
        '
        'ОткрытьЛогToolStripMenuItem
        '
        Me.ОткрытьЛогToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ПутьКЛогфайлуToolStripMenuItem, Me.ОткрытьЛогВыделенногоToolStripMenuItem, Me.ОткрытьЛогПрограммыToolStripMenuItem, Me.ToolStripMenuItem2, Me.УдалитьЛогПрограммыToolStripMenuItem})
        Me.ОткрытьЛогToolStripMenuItem.Name = "ОткрытьЛогToolStripMenuItem"
        Me.ОткрытьЛогToolStripMenuItem.Size = New System.Drawing.Size(92, 20)
        Me.ОткрытьЛогToolStripMenuItem.Text = "Логирование"
        '
        'ПутьКЛогфайлуToolStripMenuItem
        '
        Me.ПутьКЛогфайлуToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.УстановитьСтандартныйToolStripMenuItem, Me.ВвестиToolStripMenuItem})
        Me.ПутьКЛогфайлуToolStripMenuItem.Name = "ПутьКЛогфайлуToolStripMenuItem"
        Me.ПутьКЛогфайлуToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.ПутьКЛогфайлуToolStripMenuItem.Text = "Путь к лог-файлу"
        '
        'УстановитьСтандартныйToolStripMenuItem
        '
        Me.УстановитьСтандартныйToolStripMenuItem.Name = "УстановитьСтандартныйToolStripMenuItem"
        Me.УстановитьСтандартныйToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.УстановитьСтандартныйToolStripMenuItem.Text = "Установить стандартный"
        '
        'ВвестиToolStripMenuItem
        '
        Me.ВвестиToolStripMenuItem.Name = "ВвестиToolStripMenuItem"
        Me.ВвестиToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.ВвестиToolStripMenuItem.Text = "Ввести"
        '
        'ОткрытьЛогВыделенногоToolStripMenuItem
        '
        Me.ОткрытьЛогВыделенногоToolStripMenuItem.Name = "ОткрытьЛогВыделенногоToolStripMenuItem"
        Me.ОткрытьЛогВыделенногоToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.ОткрытьЛогВыделенногоToolStripMenuItem.Text = "Открыть лог выделенного"
        '
        'ОткрытьЛогПрограммыToolStripMenuItem
        '
        Me.ОткрытьЛогПрограммыToolStripMenuItem.Name = "ОткрытьЛогПрограммыToolStripMenuItem"
        Me.ОткрытьЛогПрограммыToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.ОткрытьЛогПрограммыToolStripMenuItem.Text = "Открыть лог программы"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(219, 22)
        Me.ToolStripMenuItem2.Text = "Очистить лог программы"
        '
        'УдалитьЛогПрограммыToolStripMenuItem
        '
        Me.УдалитьЛогПрограммыToolStripMenuItem.Name = "УдалитьЛогПрограммыToolStripMenuItem"
        Me.УдалитьЛогПрограммыToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.УдалитьЛогПрограммыToolStripMenuItem.Text = "Удалить лог программы"
        '
        'СправкаToolStripMenuItem
        '
        Me.СправкаToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ОПрограммеToolStripMenuItem, Me.СправкаToolStripMenuItem1})
        Me.СправкаToolStripMenuItem.Name = "СправкаToolStripMenuItem"
        Me.СправкаToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.СправкаToolStripMenuItem.Text = "Справка"
        '
        'ОПрограммеToolStripMenuItem
        '
        Me.ОПрограммеToolStripMenuItem.Name = "ОПрограммеToolStripMenuItem"
        Me.ОПрограммеToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.ОПрограммеToolStripMenuItem.Text = "О программе"
        '
        'СправкаToolStripMenuItem1
        '
        Me.СправкаToolStripMenuItem1.Name = "СправкаToolStripMenuItem1"
        Me.СправкаToolStripMenuItem1.Size = New System.Drawing.Size(149, 22)
        Me.СправкаToolStripMenuItem1.Text = "Справка"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 385)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(954, 22)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(89, 17)
        Me.ToolStripStatusLabel1.Text = "% выполнения"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusLabel2.Text = "Отчет"
        '
        'Globall
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(954, 407)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.lbx_Data)
        Me.Controls.Add(Me.btn_Exit)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximumSize = New System.Drawing.Size(970, 450)
        Me.Name = "Globall"
        Me.Text = "Архикопир"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_RefAll As Button
    Friend WithEvents btn_RefOne As Button
    Friend WithEvents btn_Add As Button
    Friend WithEvents btn_Conv As Button
    Friend WithEvents btn_Copy As Button
    Friend WithEvents btn_Del As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btn_Exit As Button
    Friend WithEvents lbx_Data As ListBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents НастройкиToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ОткрытьФайлПутейToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ВыйтиToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents СправкаToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents ПерезагрузитьПутиToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents СохранитьПутиToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ОткрытьЛогToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ОткрытьЛогВыделенногоToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ОткрытьЛогПрограммыToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ОткрытьВыделенныеПапкиToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ОПрограммеToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents СправкаToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents УдалитьЛогПрограммыToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ПутьКЛогфайлуToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ВвестиToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents УстановитьСтандартныйToolStripMenuItem As ToolStripMenuItem
End Class
