<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Valor = New System.Windows.Forms.Label()
        Me.Interes = New System.Windows.Forms.Label()
        Me.txtfuturo = New System.Windows.Forms.TextBox()
        Me.txtinteres = New System.Windows.Forms.TextBox()
        Me.txtplazo = New System.Windows.Forms.TextBox()
        Me.Plazo = New System.Windows.Forms.Label()
        Me.txtactual2 = New System.Windows.Forms.TextBox()
        Me.txtinteres2 = New System.Windows.Forms.TextBox()
        Me.txtplazo2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtinterescompuesto = New System.Windows.Forms.TextBox()
        Me.txtinteressimple = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.compuesto = New System.Windows.Forms.ComboBox()
        Me.simple = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(656, 131)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 31)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Calcular"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.Location = New System.Drawing.Point(656, 305)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 31)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Calcular"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Valor
        '
        Me.Valor.AutoSize = True
        Me.Valor.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Valor.Location = New System.Drawing.Point(75, 72)
        Me.Valor.Name = "Valor"
        Me.Valor.Size = New System.Drawing.Size(96, 20)
        Me.Valor.TabIndex = 2
        Me.Valor.Text = "Valor Futuro"
        '
        'Interes
        '
        Me.Interes.AutoSize = True
        Me.Interes.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Interes.Location = New System.Drawing.Point(201, 71)
        Me.Interes.Name = "Interes"
        Me.Interes.Size = New System.Drawing.Size(114, 20)
        Me.Interes.TabIndex = 3
        Me.Interes.Text = "Tasa de Interès"
        '
        'txtfuturo
        '
        Me.txtfuturo.Location = New System.Drawing.Point(75, 131)
        Me.txtfuturo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtfuturo.Name = "txtfuturo"
        Me.txtfuturo.Size = New System.Drawing.Size(114, 27)
        Me.txtfuturo.TabIndex = 4
        '
        'txtinteres
        '
        Me.txtinteres.Location = New System.Drawing.Point(214, 131)
        Me.txtinteres.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtinteres.Name = "txtinteres"
        Me.txtinteres.Size = New System.Drawing.Size(114, 27)
        Me.txtinteres.TabIndex = 5
        '
        'txtplazo
        '
        Me.txtplazo.Location = New System.Drawing.Point(345, 131)
        Me.txtplazo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtplazo.Name = "txtplazo"
        Me.txtplazo.Size = New System.Drawing.Size(114, 27)
        Me.txtplazo.TabIndex = 6
        '
        'Plazo
        '
        Me.Plazo.AutoSize = True
        Me.Plazo.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Plazo.Location = New System.Drawing.Point(334, 71)
        Me.Plazo.Name = "Plazo"
        Me.Plazo.Size = New System.Drawing.Size(124, 20)
        Me.Plazo.TabIndex = 7
        Me.Plazo.Text = "Plazo de Tiempo"
        '
        'txtactual2
        '
        Me.txtactual2.Location = New System.Drawing.Point(75, 304)
        Me.txtactual2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtactual2.Name = "txtactual2"
        Me.txtactual2.Size = New System.Drawing.Size(114, 27)
        Me.txtactual2.TabIndex = 8
        '
        'txtinteres2
        '
        Me.txtinteres2.Location = New System.Drawing.Point(214, 304)
        Me.txtinteres2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtinteres2.Name = "txtinteres2"
        Me.txtinteres2.Size = New System.Drawing.Size(114, 27)
        Me.txtinteres2.TabIndex = 9
        '
        'txtplazo2
        '
        Me.txtplazo2.Location = New System.Drawing.Point(345, 304)
        Me.txtplazo2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtplazo2.Name = "txtplazo2"
        Me.txtplazo2.Size = New System.Drawing.Size(114, 27)
        Me.txtplazo2.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(75, 251)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 20)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Valor Actual"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(201, 249)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 20)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Tasa de Interès"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(345, 249)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 20)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Plazo de Tiempo"
        '
        'txtinterescompuesto
        '
        Me.txtinterescompuesto.Location = New System.Drawing.Point(749, 131)
        Me.txtinterescompuesto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtinterescompuesto.Name = "txtinterescompuesto"
        Me.txtinterescompuesto.Size = New System.Drawing.Size(114, 27)
        Me.txtinterescompuesto.TabIndex = 14
        '
        'txtinteressimple
        '
        Me.txtinteressimple.Location = New System.Drawing.Point(749, 304)
        Me.txtinteressimple.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtinteressimple.Name = "txtinteressimple"
        Me.txtinteressimple.Size = New System.Drawing.Size(114, 27)
        Me.txtinteressimple.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(345, 197)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(169, 27)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "INTERÈS SIMPLE"
        '
        'compuesto
        '
        Me.compuesto.FormattingEnabled = True
        Me.compuesto.Location = New System.Drawing.Point(495, 132)
        Me.compuesto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.compuesto.Name = "compuesto"
        Me.compuesto.Size = New System.Drawing.Size(138, 28)
        Me.compuesto.TabIndex = 18
        Me.compuesto.TabStop = False
        '
        'simple
        '
        Me.simple.FormattingEnabled = True
        Me.simple.Location = New System.Drawing.Point(496, 304)
        Me.simple.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.simple.Name = "simple"
        Me.simple.Size = New System.Drawing.Size(138, 28)
        Me.simple.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(777, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 20)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Resultado"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(777, 251)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 20)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Resultado"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(482, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(164, 20)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Seleccione una Opciòn"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(487, 251)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(164, 20)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Seleccione una Opciòn"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label10.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label10.Location = New System.Drawing.Point(307, 12)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(222, 27)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "INTERÈS COMPUESTO"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(897, 387)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.simple)
        Me.Controls.Add(Me.compuesto)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtinteressimple)
        Me.Controls.Add(Me.txtinterescompuesto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtplazo2)
        Me.Controls.Add(Me.txtinteres2)
        Me.Controls.Add(Me.txtactual2)
        Me.Controls.Add(Me.Plazo)
        Me.Controls.Add(Me.txtplazo)
        Me.Controls.Add(Me.txtinteres)
        Me.Controls.Add(Me.txtfuturo)
        Me.Controls.Add(Me.Interes)
        Me.Controls.Add(Me.Valor)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Name = "Form1"
        Me.Text = "Resultado"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Valor As Label
    Friend WithEvents Interes As Label
    Friend WithEvents txtfuturo As TextBox
    Friend WithEvents txtinteres As TextBox
    Friend WithEvents txtplazo As TextBox
    Friend WithEvents Plazo As Label
    Friend WithEvents txtactual2 As TextBox
    Friend WithEvents txtinteres2 As TextBox
    Friend WithEvents txtplazo2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtinterescompuesto As TextBox
    Friend WithEvents txtinteressimple As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents compuesto As ComboBox
    Friend WithEvents simple As ComboBox

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        compuesto.Items.Add("Meses")
        compuesto.Items.Add("Años")
        simple.Items.Add("Meses")
        simple.Items.Add("Años")
    End Sub

    Private Sub txtfuturo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtfuturo.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo Puede digitar numeros")
        End If
    End Sub

    Private Sub txtplazo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtplazo.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo Puede digitar numeros")
        End If
    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim actualsimple As Double
        Dim interesimple As Double
        Dim plazosimple As Double
        Dim interes_simple As Double

        actualsimple = txtactual2.Text
        interesimple = txtinteres2.Text
        plazosimple = txtplazo2.Text

        Select Case simple.SelectedIndex
            Case 0
                plazosimple = plazosimple / 12
                interes_simple = actualsimple * (1 + plazosimple * interesimple)
            Case 1
                interes_simple = actualsimple * (1 + plazosimple * interesimple)

        End Select
        interes_simple = Math.Round(Convert.ToDouble(interes_simple), 2)
        txtinteressimple.Text = ("$" & interes_simple)
    End Sub

    Friend WithEvents Label10 As Label

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim futuro_compuesto As Double
        Dim interes_compuesto As Double
        Dim plazo_compuesto As Double
        Dim interescompuesto As Double

        futuro_compuesto = txtfuturo.Text
        interes_compuesto = txtinteres.Text
        plazo_compuesto = txtplazo.Text


        Select Case compuesto.SelectedIndex
            Case 0
                plazo_compuesto = plazo_compuesto / 12
                interescompuesto = (futuro_compuesto) * (1 + interes_compuesto) ^ plazo_compuesto
            Case 1
                interescompuesto = (futuro_compuesto) * (1 + interes_compuesto) ^ plazo_compuesto


        End Select
        interescompuesto = Math.Round(Convert.ToDouble(interescompuesto), 2)
        txtinterescompuesto.Text = ("$" & interescompuesto)
    End Sub

End Class
