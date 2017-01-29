<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InterfazPicDice
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Jugador1 = New System.Windows.Forms.TextBox()
        Me.Maquina = New System.Windows.Forms.TextBox()
        Me.lbldado1 = New System.Windows.Forms.TextBox()
        Me.Puntaje = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Jugador = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Sumatoria = New System.Windows.Forms.Label()
        Me.PicDado = New System.Windows.Forms.PictureBox()
        Me.Perdio = New System.Windows.Forms.TextBox()
        CType(Me.PicDado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Jugador1
        '
        Me.Jugador1.Location = New System.Drawing.Point(125, 37)
        Me.Jugador1.Name = "Jugador1"
        Me.Jugador1.Size = New System.Drawing.Size(100, 20)
        Me.Jugador1.TabIndex = 0
        '
        'Maquina
        '
        Me.Maquina.Location = New System.Drawing.Point(387, 37)
        Me.Maquina.Name = "Maquina"
        Me.Maquina.Size = New System.Drawing.Size(100, 20)
        Me.Maquina.TabIndex = 1
        '
        'lbldado1
        '
        Me.lbldado1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.lbldado1.ForeColor = System.Drawing.SystemColors.Window
        Me.lbldado1.Location = New System.Drawing.Point(308, 283)
        Me.lbldado1.Name = "lbldado1"
        Me.lbldado1.Size = New System.Drawing.Size(100, 20)
        Me.lbldado1.TabIndex = 2
        Me.lbldado1.Text = "DADO1"
        '
        'Puntaje
        '
        Me.Puntaje.Location = New System.Drawing.Point(27, 198)
        Me.Puntaje.Name = "Puntaje"
        Me.Puntaje.Size = New System.Drawing.Size(100, 20)
        Me.Puntaje.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(288, 309)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(138, 58)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Spin"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(27, 327)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Stop"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Jugador
        '
        Me.Jugador.AutoSize = True
        Me.Jugador.Location = New System.Drawing.Point(146, 60)
        Me.Jugador.Name = "Jugador"
        Me.Jugador.Size = New System.Drawing.Size(54, 13)
        Me.Jugador.TabIndex = 6
        Me.Jugador.Text = "Jugador 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(448, 221)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(417, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Maquina"
        '
        'Sumatoria
        '
        Me.Sumatoria.AutoSize = True
        Me.Sumatoria.Location = New System.Drawing.Point(48, 234)
        Me.Sumatoria.Name = "Sumatoria"
        Me.Sumatoria.Size = New System.Drawing.Size(54, 13)
        Me.Sumatoria.TabIndex = 9
        Me.Sumatoria.Text = "Sumatoria"
        '
        'PicDado
        '
        Me.PicDado.Location = New System.Drawing.Point(308, 198)
        Me.PicDado.Name = "PicDado"
        Me.PicDado.Size = New System.Drawing.Size(100, 72)
        Me.PicDado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicDado.TabIndex = 10
        Me.PicDado.TabStop = False
        '
        'Perdio
        '
        Me.Perdio.Location = New System.Drawing.Point(172, 126)
        Me.Perdio.Name = "Perdio"
        Me.Perdio.Size = New System.Drawing.Size(254, 20)
        Me.Perdio.TabIndex = 11
        '
        'InterfazPicDice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GreenYellow
        Me.ClientSize = New System.Drawing.Size(625, 382)
        Me.Controls.Add(Me.Perdio)
        Me.Controls.Add(Me.PicDado)
        Me.Controls.Add(Me.Sumatoria)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Jugador)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Puntaje)
        Me.Controls.Add(Me.lbldado1)
        Me.Controls.Add(Me.Maquina)
        Me.Controls.Add(Me.Jugador1)
        Me.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Name = "InterfazPicDice"
        Me.Text = "InterfazPicDice"
        CType(Me.PicDado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Jugador1 As TextBox
    Friend WithEvents Maquina As TextBox
    Friend WithEvents lbldado1 As TextBox
    Friend WithEvents Puntaje As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Jugador As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Sumatoria As Label
    Friend WithEvents PicDado As PictureBox
    Friend WithEvents Perdio As TextBox
End Class
