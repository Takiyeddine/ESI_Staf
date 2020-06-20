<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LOADING
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuProgressBar5 = New Bunifu.Framework.UI.BunifuProgressBar()
        Me.SuspendLayout()
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Century Gothic", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(225, 162)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(424, 72)
        Me.BunifuCustomLabel1.TabIndex = 290
        Me.BunifuCustomLabel1.Text = "Veuillez paittienez ..."
        '
        'BunifuProgressBar5
        '
        Me.BunifuProgressBar5.BackColor = System.Drawing.Color.Silver
        Me.BunifuProgressBar5.BorderRadius = 5
        Me.BunifuProgressBar5.Location = New System.Drawing.Point(88, 271)
        Me.BunifuProgressBar5.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuProgressBar5.MaximumValue = 100
        Me.BunifuProgressBar5.Name = "BunifuProgressBar5"
        Me.BunifuProgressBar5.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BunifuProgressBar5.Size = New System.Drawing.Size(612, 15)
        Me.BunifuProgressBar5.TabIndex = 291
        Me.BunifuProgressBar5.Value = 60
        '
        'LOADING
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BunifuProgressBar5)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LOADING"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOADING"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuProgressBar5 As Bunifu.Framework.UI.BunifuProgressBar
End Class
