<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ProgramDataSet = New AppLogin.ProgramDataSet()
        Me.DoituongBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DoituongTableAdapter = New AppLogin.ProgramDataSetTableAdapters.doituongTableAdapter()
        Me.TableAdapterManager = New AppLogin.ProgramDataSetTableAdapters.TableAdapterManager()
        CType(Me.ProgramDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DoituongBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtusername
        '
        Me.txtusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtusername.Location = New System.Drawing.Point(175, 84)
        Me.txtusername.Multiline = True
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(217, 37)
        Me.txtusername.TabIndex = 0
        '
        'txtpassword
        '
        Me.txtpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtpassword.Location = New System.Drawing.Point(175, 139)
        Me.txtpassword.Multiline = True
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtpassword.Size = New System.Drawing.Size(217, 37)
        Me.txtpassword.TabIndex = 1
        '
        'btnLogin
        '
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(175, 209)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(217, 37)
        Me.btnLogin.TabIndex = 2
        Me.btnLogin.Text = "Đăng nhập"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Tên đăng nhập"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Mật khẩu"
        '
        'ProgramDataSet
        '
        Me.ProgramDataSet.DataSetName = "ProgramDataSet"
        Me.ProgramDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DoituongBindingSource
        '
        Me.DoituongBindingSource.DataMember = "doituong"
        Me.DoituongBindingSource.DataSource = Me.ProgramDataSet
        '
        'DoituongTableAdapter
        '
        Me.DoituongTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.doituongTableAdapter = Me.DoituongTableAdapter
        Me.TableAdapterManager.Tb_DienNuocTableAdapter = Nothing
        Me.TableAdapterManager.Tb_HoaDonTableAdapter = Nothing
        Me.TableAdapterManager.Tb_HopDongTableAdapter = Nothing
        Me.TableAdapterManager.Tb_LoaiPhongTableAdapter = Nothing
        Me.TableAdapterManager.Tb_PhongTableAdapter = Nothing
        Me.TableAdapterManager.Tb_SinhVienTableAdapter = Nothing
        Me.TableAdapterManager.tb_userTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = AppLogin.ProgramDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(768, 306)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.txtusername)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.ProgramDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DoituongBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtusername As System.Windows.Forms.TextBox
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents ProgramDataSet As AppLogin.ProgramDataSet
    Friend WithEvents DoituongBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DoituongTableAdapter As AppLogin.ProgramDataSetTableAdapters.doituongTableAdapter
    Friend WithEvents TableAdapterManager As AppLogin.ProgramDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
