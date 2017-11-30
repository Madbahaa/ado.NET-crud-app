<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.idtxt = New System.Windows.Forms.TextBox()
        Me.nomtxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.prenomtxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ajoutercmd = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.prenommodtxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.idmodtxt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.nommodtxt = New System.Windows.Forms.TextBox()
        Me.modifiercmd = New System.Windows.Forms.Button()
        Me.Supression = New System.Windows.Forms.TabPage()
        Me.idsuppcmd = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.supprimercmd = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Supression.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(66, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "id"
        '
        'idtxt
        '
        Me.idtxt.Location = New System.Drawing.Point(136, 38)
        Me.idtxt.Name = "idtxt"
        Me.idtxt.Size = New System.Drawing.Size(136, 20)
        Me.idtxt.TabIndex = 1
        '
        'nomtxt
        '
        Me.nomtxt.Location = New System.Drawing.Point(136, 94)
        Me.nomtxt.Name = "nomtxt"
        Me.nomtxt.Size = New System.Drawing.Size(136, 20)
        Me.nomtxt.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(66, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "nom"
        '
        'prenomtxt
        '
        Me.prenomtxt.Location = New System.Drawing.Point(136, 152)
        Me.prenomtxt.Name = "prenomtxt"
        Me.prenomtxt.Size = New System.Drawing.Size(136, 20)
        Me.prenomtxt.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(66, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "prenom"
        '
        'ajoutercmd
        '
        Me.ajoutercmd.Location = New System.Drawing.Point(325, 177)
        Me.ajoutercmd.Name = "ajoutercmd"
        Me.ajoutercmd.Size = New System.Drawing.Size(98, 39)
        Me.ajoutercmd.TabIndex = 6
        Me.ajoutercmd.Text = "Ajouter"
        Me.ajoutercmd.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.Supression)
        Me.TabControl1.Location = New System.Drawing.Point(1, 1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(446, 260)
        Me.TabControl1.TabIndex = 8
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.prenomtxt)
        Me.TabPage1.Controls.Add(Me.ajoutercmd)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.idtxt)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.nomtxt)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(438, 234)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Ajout"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.prenommodtxt)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.idmodtxt)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.nommodtxt)
        Me.TabPage2.Controls.Add(Me.modifiercmd)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(438, 234)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "modification"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'prenommodtxt
        '
        Me.prenommodtxt.Location = New System.Drawing.Point(136, 152)
        Me.prenommodtxt.Name = "prenommodtxt"
        Me.prenommodtxt.Size = New System.Drawing.Size(136, 20)
        Me.prenommodtxt.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(66, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(15, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "id"
        '
        'idmodtxt
        '
        Me.idmodtxt.Location = New System.Drawing.Point(136, 38)
        Me.idmodtxt.Name = "idmodtxt"
        Me.idmodtxt.Size = New System.Drawing.Size(136, 20)
        Me.idmodtxt.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(66, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "prenom"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(66, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "nom"
        '
        'nommodtxt
        '
        Me.nommodtxt.Location = New System.Drawing.Point(136, 94)
        Me.nommodtxt.Name = "nommodtxt"
        Me.nommodtxt.Size = New System.Drawing.Size(136, 20)
        Me.nommodtxt.TabIndex = 11
        '
        'modifiercmd
        '
        Me.modifiercmd.Location = New System.Drawing.Point(324, 176)
        Me.modifiercmd.Name = "modifiercmd"
        Me.modifiercmd.Size = New System.Drawing.Size(98, 39)
        Me.modifiercmd.TabIndex = 7
        Me.modifiercmd.Text = "Modifier"
        Me.modifiercmd.UseVisualStyleBackColor = True
        '
        'Supression
        '
        Me.Supression.Controls.Add(Me.idsuppcmd)
        Me.Supression.Controls.Add(Me.Label7)
        Me.Supression.Controls.Add(Me.supprimercmd)
        Me.Supression.Location = New System.Drawing.Point(4, 22)
        Me.Supression.Name = "Supression"
        Me.Supression.Padding = New System.Windows.Forms.Padding(3)
        Me.Supression.Size = New System.Drawing.Size(438, 234)
        Me.Supression.TabIndex = 2
        Me.Supression.Text = "Supression"
        Me.Supression.UseVisualStyleBackColor = True
        '
        'idsuppcmd
        '
        Me.idsuppcmd.Location = New System.Drawing.Point(156, 86)
        Me.idsuppcmd.Name = "idsuppcmd"
        Me.idsuppcmd.Size = New System.Drawing.Size(136, 20)
        Me.idsuppcmd.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(217, 55)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(15, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "id"
        '
        'supprimercmd
        '
        Me.supprimercmd.Location = New System.Drawing.Point(175, 129)
        Me.supprimercmd.Name = "supprimercmd"
        Me.supprimercmd.Size = New System.Drawing.Size(98, 39)
        Me.supprimercmd.TabIndex = 14
        Me.supprimercmd.Text = "Supprimer"
        Me.supprimercmd.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 261)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Gestion etudiant ado.net"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.Supression.ResumeLayout(False)
        Me.Supression.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents idtxt As System.Windows.Forms.TextBox
    Friend WithEvents nomtxt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents prenomtxt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ajoutercmd As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents prenommodtxt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents idmodtxt As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents nommodtxt As System.Windows.Forms.TextBox
    Friend WithEvents modifiercmd As System.Windows.Forms.Button
    Friend WithEvents Supression As System.Windows.Forms.TabPage
    Friend WithEvents idsuppcmd As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents supprimercmd As System.Windows.Forms.Button

End Class
