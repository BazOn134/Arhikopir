<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Add
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
        Me.lbl_Ist = New System.Windows.Forms.Label()
        Me.lbl_Pol = New System.Windows.Forms.Label()
        Me.tbx_Pol = New System.Windows.Forms.TextBox()
        Me.tbx_Ist = New System.Windows.Forms.TextBox()
        Me.btn_AddFoldIst = New System.Windows.Forms.Button()
        Me.btn_AddFoldPol = New System.Windows.Forms.Button()
        Me.btn_Zapis = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_Ist
        '
        Me.lbl_Ist.AutoSize = True
        Me.lbl_Ist.Location = New System.Drawing.Point(9, 12)
        Me.lbl_Ist.Name = "lbl_Ist"
        Me.lbl_Ist.Size = New System.Drawing.Size(55, 13)
        Me.lbl_Ist.TabIndex = 0
        Me.lbl_Ist.Text = "Источник"
        '
        'lbl_Pol
        '
        Me.lbl_Pol.AutoSize = True
        Me.lbl_Pol.Location = New System.Drawing.Point(9, 42)
        Me.lbl_Pol.Name = "lbl_Pol"
        Me.lbl_Pol.Size = New System.Drawing.Size(66, 13)
        Me.lbl_Pol.TabIndex = 0
        Me.lbl_Pol.Text = "Получатель"
        '
        'tbx_Pol
        '
        Me.tbx_Pol.Location = New System.Drawing.Point(86, 39)
        Me.tbx_Pol.Name = "tbx_Pol"
        Me.tbx_Pol.Size = New System.Drawing.Size(432, 20)
        Me.tbx_Pol.TabIndex = 1
        '
        'tbx_Ist
        '
        Me.tbx_Ist.Location = New System.Drawing.Point(86, 12)
        Me.tbx_Ist.Name = "tbx_Ist"
        Me.tbx_Ist.Size = New System.Drawing.Size(432, 20)
        Me.tbx_Ist.TabIndex = 1
        '
        'btn_AddFoldIst
        '
        Me.btn_AddFoldIst.Location = New System.Drawing.Point(524, 12)
        Me.btn_AddFoldIst.Name = "btn_AddFoldIst"
        Me.btn_AddFoldIst.Size = New System.Drawing.Size(27, 20)
        Me.btn_AddFoldIst.TabIndex = 2
        Me.btn_AddFoldIst.Text = "..."
        Me.btn_AddFoldIst.UseVisualStyleBackColor = True
        '
        'btn_AddFoldPol
        '
        Me.btn_AddFoldPol.Location = New System.Drawing.Point(524, 39)
        Me.btn_AddFoldPol.Name = "btn_AddFoldPol"
        Me.btn_AddFoldPol.Size = New System.Drawing.Size(27, 20)
        Me.btn_AddFoldPol.TabIndex = 2
        Me.btn_AddFoldPol.Text = "..."
        Me.btn_AddFoldPol.UseVisualStyleBackColor = True
        '
        'btn_Zapis
        '
        Me.btn_Zapis.Location = New System.Drawing.Point(424, 65)
        Me.btn_Zapis.Name = "btn_Zapis"
        Me.btn_Zapis.Size = New System.Drawing.Size(127, 29)
        Me.btn_Zapis.TabIndex = 3
        Me.btn_Zapis.Text = "Записать"
        Me.btn_Zapis.UseVisualStyleBackColor = True
        '
        'frm_Add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 97)
        Me.Controls.Add(Me.btn_Zapis)
        Me.Controls.Add(Me.btn_AddFoldPol)
        Me.Controls.Add(Me.btn_AddFoldIst)
        Me.Controls.Add(Me.tbx_Ist)
        Me.Controls.Add(Me.tbx_Pol)
        Me.Controls.Add(Me.lbl_Pol)
        Me.Controls.Add(Me.lbl_Ist)
        Me.Name = "frm_Add"
        Me.Text = "Выбор папок резервирования"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_Ist As Label
    Friend WithEvents lbl_Pol As Label
    Friend WithEvents tbx_Pol As TextBox
    Friend WithEvents tbx_Ist As TextBox
    Friend WithEvents btn_AddFoldIst As Button
    Friend WithEvents btn_AddFoldPol As Button
    Friend WithEvents btn_Zapis As Button
End Class
