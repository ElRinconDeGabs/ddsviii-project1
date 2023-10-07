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
        Lbl_tittle = New Label()
        Lbl_time = New Label()
        Tb_timer = New TextBox()
        Btn_start = New Button()
        Btn_suma = New Button()
        Btn_resta = New Button()
        Btn_div = New Button()
        Btn_por = New Button()
        Btn_number3 = New Button()
        Btn_number4 = New Button()
        Btn_number2 = New Button()
        Btn_number1 = New Button()
        Tb_operation1 = New TextBox()
        Tb_operation7 = New TextBox()
        Tb_operation6 = New TextBox()
        Tb_operation5 = New TextBox()
        Tb_operation4 = New TextBox()
        Tb_operation3 = New TextBox()
        Tb_operation2 = New TextBox()
        Label1 = New Label()
        Tb_result = New TextBox()
        Label2 = New Label()
        Btn_clearCI = New Button()
        Btn_clearAll = New Button()
        Btn_solution = New Button()
        Btn_next = New Button()
        Tb_partialResult = New TextBox()
        Tb_resultOp = New TextBox()
        Label3 = New Label()
        Tb_resultOp2 = New TextBox()
        Tb_resultOp3 = New TextBox()
        Tb_resultOp4 = New TextBox()
        Tb_resultOp5 = New TextBox()
        Tb_resultOp6 = New TextBox()
        Tb_resultOp7 = New TextBox()
        Tb_resultOp1 = New TextBox()
        Tb_hits = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        SuspendLayout()
        ' 
        ' Lbl_tittle
        ' 
        Lbl_tittle.AutoSize = True
        Lbl_tittle.Font = New Font("Sitka Text", 15.7499981F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Lbl_tittle.Location = New Point(124, 31)
        Lbl_tittle.Name = "Lbl_tittle"
        Lbl_tittle.Size = New Size(373, 30)
        Lbl_tittle.TabIndex = 0
        Lbl_tittle.Text = "PROYECTO NO. 1: Reto Matemático"
        Lbl_tittle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Lbl_time
        ' 
        Lbl_time.AutoSize = True
        Lbl_time.Location = New Point(397, 94)
        Lbl_time.Name = "Lbl_time"
        Lbl_time.Size = New Size(53, 15)
        Lbl_time.TabIndex = 1
        Lbl_time.Text = "Tiempo: "
        Lbl_time.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Tb_timer
        ' 
        Tb_timer.BackColor = SystemColors.ButtonHighlight
        Tb_timer.Enabled = False
        Tb_timer.Location = New Point(456, 91)
        Tb_timer.Name = "Tb_timer"
        Tb_timer.Size = New Size(53, 23)
        Tb_timer.TabIndex = 2
        Tb_timer.TextAlign = HorizontalAlignment.Center
        ' 
        ' Btn_start
        ' 
        Btn_start.Location = New Point(364, 166)
        Btn_start.Name = "Btn_start"
        Btn_start.Size = New Size(75, 23)
        Btn_start.TabIndex = 3
        Btn_start.Text = "Iniciar"
        Btn_start.UseVisualStyleBackColor = True
        ' 
        ' Btn_suma
        ' 
        Btn_suma.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Btn_suma.AutoSize = True
        Btn_suma.Cursor = Cursors.No
        Btn_suma.Font = New Font("Bell MT", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Btn_suma.Location = New Point(79, 256)
        Btn_suma.Margin = New Padding(5)
        Btn_suma.Name = "Btn_suma"
        Btn_suma.Padding = New Padding(2)
        Btn_suma.Size = New Size(10, 10)
        Btn_suma.TabIndex = 8
        Btn_suma.UseVisualStyleBackColor = True
        ' 
        ' Btn_resta
        ' 
        Btn_resta.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Btn_resta.AutoSize = True
        Btn_resta.Cursor = Cursors.No
        Btn_resta.Font = New Font("Bell MT", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Btn_resta.Location = New Point(125, 256)
        Btn_resta.Margin = New Padding(5)
        Btn_resta.Name = "Btn_resta"
        Btn_resta.Padding = New Padding(2)
        Btn_resta.Size = New Size(10, 10)
        Btn_resta.TabIndex = 9
        Btn_resta.UseVisualStyleBackColor = True
        ' 
        ' Btn_div
        ' 
        Btn_div.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Btn_div.AutoSize = True
        Btn_div.Cursor = Cursors.No
        Btn_div.Font = New Font("Bell MT", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Btn_div.Location = New Point(215, 256)
        Btn_div.Margin = New Padding(5)
        Btn_div.Name = "Btn_div"
        Btn_div.Padding = New Padding(2)
        Btn_div.Size = New Size(10, 10)
        Btn_div.TabIndex = 10
        Btn_div.UseVisualStyleBackColor = True
        ' 
        ' Btn_por
        ' 
        Btn_por.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Btn_por.AutoSize = True
        Btn_por.Cursor = Cursors.No
        Btn_por.Font = New Font("Bell MT", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Btn_por.Location = New Point(169, 256)
        Btn_por.Margin = New Padding(5)
        Btn_por.Name = "Btn_por"
        Btn_por.Padding = New Padding(2)
        Btn_por.Size = New Size(10, 10)
        Btn_por.TabIndex = 11
        Btn_por.UseVisualStyleBackColor = True
        ' 
        ' Btn_number3
        ' 
        Btn_number3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Btn_number3.AutoSize = True
        Btn_number3.Cursor = Cursors.No
        Btn_number3.Font = New Font("Bell MT", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Btn_number3.Location = New Point(169, 213)
        Btn_number3.Margin = New Padding(5)
        Btn_number3.Name = "Btn_number3"
        Btn_number3.Padding = New Padding(2)
        Btn_number3.Size = New Size(10, 10)
        Btn_number3.TabIndex = 15
        Btn_number3.UseVisualStyleBackColor = True
        ' 
        ' Btn_number4
        ' 
        Btn_number4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Btn_number4.AutoSize = True
        Btn_number4.Cursor = Cursors.No
        Btn_number4.Font = New Font("Bell MT", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Btn_number4.Location = New Point(215, 213)
        Btn_number4.Margin = New Padding(5)
        Btn_number4.Name = "Btn_number4"
        Btn_number4.Padding = New Padding(2)
        Btn_number4.Size = New Size(10, 10)
        Btn_number4.TabIndex = 14
        Btn_number4.UseVisualStyleBackColor = True
        ' 
        ' Btn_number2
        ' 
        Btn_number2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Btn_number2.AutoSize = True
        Btn_number2.Cursor = Cursors.No
        Btn_number2.Font = New Font("Bell MT", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Btn_number2.Location = New Point(125, 213)
        Btn_number2.Margin = New Padding(5)
        Btn_number2.Name = "Btn_number2"
        Btn_number2.Padding = New Padding(2)
        Btn_number2.Size = New Size(10, 10)
        Btn_number2.TabIndex = 13
        Btn_number2.UseVisualStyleBackColor = True
        ' 
        ' Btn_number1
        ' 
        Btn_number1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Btn_number1.AutoSize = True
        Btn_number1.Cursor = Cursors.No
        Btn_number1.Font = New Font("Bell MT", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Btn_number1.Location = New Point(79, 213)
        Btn_number1.Margin = New Padding(5)
        Btn_number1.Name = "Btn_number1"
        Btn_number1.Padding = New Padding(2)
        Btn_number1.Size = New Size(10, 10)
        Btn_number1.TabIndex = 12
        Btn_number1.UseVisualStyleBackColor = True
        ' 
        ' Tb_operation1
        ' 
        Tb_operation1.Enabled = False
        Tb_operation1.HideSelection = False
        Tb_operation1.Location = New Point(51, 171)
        Tb_operation1.Name = "Tb_operation1"
        Tb_operation1.Size = New Size(24, 23)
        Tb_operation1.TabIndex = 16
        Tb_operation1.TextAlign = HorizontalAlignment.Center
        ' 
        ' Tb_operation7
        ' 
        Tb_operation7.Enabled = False
        Tb_operation7.HideSelection = False
        Tb_operation7.Location = New Point(231, 171)
        Tb_operation7.Name = "Tb_operation7"
        Tb_operation7.Size = New Size(24, 23)
        Tb_operation7.TabIndex = 18
        Tb_operation7.TextAlign = HorizontalAlignment.Center
        ' 
        ' Tb_operation6
        ' 
        Tb_operation6.Enabled = False
        Tb_operation6.HideSelection = False
        Tb_operation6.Location = New Point(201, 171)
        Tb_operation6.Name = "Tb_operation6"
        Tb_operation6.Size = New Size(24, 23)
        Tb_operation6.TabIndex = 19
        Tb_operation6.TextAlign = HorizontalAlignment.Center
        ' 
        ' Tb_operation5
        ' 
        Tb_operation5.Enabled = False
        Tb_operation5.HideSelection = False
        Tb_operation5.Location = New Point(171, 171)
        Tb_operation5.Name = "Tb_operation5"
        Tb_operation5.Size = New Size(24, 23)
        Tb_operation5.TabIndex = 20
        Tb_operation5.TextAlign = HorizontalAlignment.Center
        ' 
        ' Tb_operation4
        ' 
        Tb_operation4.Enabled = False
        Tb_operation4.HideSelection = False
        Tb_operation4.Location = New Point(141, 171)
        Tb_operation4.Name = "Tb_operation4"
        Tb_operation4.Size = New Size(24, 23)
        Tb_operation4.TabIndex = 21
        Tb_operation4.TextAlign = HorizontalAlignment.Center
        ' 
        ' Tb_operation3
        ' 
        Tb_operation3.Enabled = False
        Tb_operation3.HideSelection = False
        Tb_operation3.Location = New Point(111, 171)
        Tb_operation3.Name = "Tb_operation3"
        Tb_operation3.Size = New Size(24, 23)
        Tb_operation3.TabIndex = 22
        Tb_operation3.TextAlign = HorizontalAlignment.Center
        ' 
        ' Tb_operation2
        ' 
        Tb_operation2.Enabled = False
        Tb_operation2.HideSelection = False
        Tb_operation2.Location = New Point(81, 171)
        Tb_operation2.Name = "Tb_operation2"
        Tb_operation2.Size = New Size(24, 23)
        Tb_operation2.TabIndex = 23
        Tb_operation2.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(256, 174)
        Label1.Name = "Label1"
        Label1.Size = New Size(15, 15)
        Label1.TabIndex = 24
        Label1.Text = "="
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Tb_result
        ' 
        Tb_result.Enabled = False
        Tb_result.HideSelection = False
        Tb_result.Location = New Point(277, 171)
        Tb_result.Name = "Tb_result"
        Tb_result.Size = New Size(24, 23)
        Tb_result.TabIndex = 25
        Tb_result.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(397, 123)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 15)
        Label2.TabIndex = 27
        Label2.Text = "Aciertos: "
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Btn_clearCI
        ' 
        Btn_clearCI.Location = New Point(364, 195)
        Btn_clearCI.Name = "Btn_clearCI"
        Btn_clearCI.Size = New Size(75, 23)
        Btn_clearCI.TabIndex = 29
        Btn_clearCI.Text = "Borrar"
        Btn_clearCI.UseVisualStyleBackColor = True
        ' 
        ' Btn_clearAll
        ' 
        Btn_clearAll.Location = New Point(364, 224)
        Btn_clearAll.Name = "Btn_clearAll"
        Btn_clearAll.Size = New Size(75, 23)
        Btn_clearAll.TabIndex = 30
        Btn_clearAll.Text = "Borrar todo"
        Btn_clearAll.UseVisualStyleBackColor = True
        ' 
        ' Btn_solution
        ' 
        Btn_solution.Location = New Point(364, 256)
        Btn_solution.Name = "Btn_solution"
        Btn_solution.Size = New Size(75, 23)
        Btn_solution.TabIndex = 31
        Btn_solution.Text = "Resolver"
        Btn_solution.UseVisualStyleBackColor = True
        ' 
        ' Btn_next
        ' 
        Btn_next.Location = New Point(364, 285)
        Btn_next.Name = "Btn_next"
        Btn_next.Size = New Size(75, 23)
        Btn_next.TabIndex = 32
        Btn_next.Text = "Siguiente"
        Btn_next.UseVisualStyleBackColor = True
        ' 
        ' Tb_partialResult
        ' 
        Tb_partialResult.Enabled = False
        Tb_partialResult.HideSelection = False
        Tb_partialResult.Location = New Point(277, 208)
        Tb_partialResult.Name = "Tb_partialResult"
        Tb_partialResult.Size = New Size(24, 23)
        Tb_partialResult.TabIndex = 33
        Tb_partialResult.TextAlign = HorizontalAlignment.Center
        ' 
        ' Tb_resultOp
        ' 
        Tb_resultOp.HideSelection = False
        Tb_resultOp.Location = New Point(277, 123)
        Tb_resultOp.Name = "Tb_resultOp"
        Tb_resultOp.Size = New Size(24, 23)
        Tb_resultOp.TabIndex = 42
        Tb_resultOp.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(256, 126)
        Label3.Name = "Label3"
        Label3.Size = New Size(15, 15)
        Label3.TabIndex = 41
        Label3.Text = "="
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Tb_resultOp2
        ' 
        Tb_resultOp2.Location = New Point(81, 123)
        Tb_resultOp2.Name = "Tb_resultOp2"
        Tb_resultOp2.Size = New Size(24, 23)
        Tb_resultOp2.TabIndex = 40
        Tb_resultOp2.TextAlign = HorizontalAlignment.Center
        ' 
        ' Tb_resultOp3
        ' 
        Tb_resultOp3.Location = New Point(111, 123)
        Tb_resultOp3.Name = "Tb_resultOp3"
        Tb_resultOp3.Size = New Size(24, 23)
        Tb_resultOp3.TabIndex = 39
        Tb_resultOp3.TextAlign = HorizontalAlignment.Center
        ' 
        ' Tb_resultOp4
        ' 
        Tb_resultOp4.Location = New Point(141, 123)
        Tb_resultOp4.Name = "Tb_resultOp4"
        Tb_resultOp4.Size = New Size(24, 23)
        Tb_resultOp4.TabIndex = 38
        Tb_resultOp4.TextAlign = HorizontalAlignment.Center
        ' 
        ' Tb_resultOp5
        ' 
        Tb_resultOp5.Location = New Point(171, 123)
        Tb_resultOp5.Name = "Tb_resultOp5"
        Tb_resultOp5.Size = New Size(24, 23)
        Tb_resultOp5.TabIndex = 37
        Tb_resultOp5.TextAlign = HorizontalAlignment.Center
        ' 
        ' Tb_resultOp6
        ' 
        Tb_resultOp6.Location = New Point(201, 123)
        Tb_resultOp6.Name = "Tb_resultOp6"
        Tb_resultOp6.Size = New Size(24, 23)
        Tb_resultOp6.TabIndex = 36
        Tb_resultOp6.TextAlign = HorizontalAlignment.Center
        ' 
        ' Tb_resultOp7
        ' 
        Tb_resultOp7.Location = New Point(231, 123)
        Tb_resultOp7.Name = "Tb_resultOp7"
        Tb_resultOp7.Size = New Size(24, 23)
        Tb_resultOp7.TabIndex = 35
        Tb_resultOp7.TextAlign = HorizontalAlignment.Center
        ' 
        ' Tb_resultOp1
        ' 
        Tb_resultOp1.HideSelection = False
        Tb_resultOp1.Location = New Point(51, 123)
        Tb_resultOp1.Name = "Tb_resultOp1"
        Tb_resultOp1.Size = New Size(24, 23)
        Tb_resultOp1.TabIndex = 34
        Tb_resultOp1.TextAlign = HorizontalAlignment.Center
        ' 
        ' Tb_hits
        ' 
        Tb_hits.Location = New Point(456, 123)
        Tb_hits.Name = "Tb_hits"
        Tb_hits.Size = New Size(53, 23)
        Tb_hits.TabIndex = 43
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Sitka Small", 11.249999F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(111, 362)
        Label5.Name = "Label5"
        Label5.Size = New Size(350, 21)
        Label5.TabIndex = 45
        Label5.Text = "UNIVERSIDAD TECNOLÓGICA DE PANAMÁ"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Sitka Small", 11.249999F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(51, 383)
        Label6.Name = "Label6"
        Label6.Size = New Size(491, 21)
        Label6.TabIndex = 46
        Label6.Text = "FACULTAD DE INGENIERIA DE SISTEMAS COMPUTACIONES"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Sitka Small", 11.249999F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(124, 404)
        Label7.Name = "Label7"
        Label7.Size = New Size(280, 21)
        Label7.TabIndex = 47
        Label7.Text = "DESARROLLO DE SOFTWARE VIII"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Sitka Small", 11.249999F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(182, 434)
        Label8.Name = "Label8"
        Label8.Size = New Size(129, 21)
        Label8.TabIndex = 48
        Label8.Text = "PROYECTO N°1"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Sitka Small", 11.249999F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(169, 455)
        Label9.Name = "Label9"
        Label9.Size = New Size(165, 21)
        Label9.TabIndex = 49
        Label9.Text = "ISAAC SAMANIEGO"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Sitka Small", 11.249999F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.Location = New Point(203, 476)
        Label10.Name = "Label10"
        Label10.Size = New Size(98, 21)
        Label10.TabIndex = 50
        Label10.Text = "8-964-2210"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Sitka Small", 11.249999F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.Location = New Point(215, 497)
        Label11.Name = "Label11"
        Label11.Size = New Size(64, 21)
        Label11.TabIndex = 51
        Label11.Text = "1LS231"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackColor = Color.Pink
        ClientSize = New Size(575, 527)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Tb_hits)
        Controls.Add(Tb_resultOp)
        Controls.Add(Label3)
        Controls.Add(Tb_resultOp2)
        Controls.Add(Tb_resultOp3)
        Controls.Add(Tb_resultOp4)
        Controls.Add(Tb_resultOp5)
        Controls.Add(Tb_resultOp6)
        Controls.Add(Tb_resultOp7)
        Controls.Add(Tb_resultOp1)
        Controls.Add(Tb_partialResult)
        Controls.Add(Btn_next)
        Controls.Add(Btn_solution)
        Controls.Add(Btn_clearAll)
        Controls.Add(Btn_clearCI)
        Controls.Add(Label2)
        Controls.Add(Tb_result)
        Controls.Add(Label1)
        Controls.Add(Tb_operation2)
        Controls.Add(Tb_operation3)
        Controls.Add(Tb_operation4)
        Controls.Add(Tb_operation5)
        Controls.Add(Tb_operation6)
        Controls.Add(Tb_operation7)
        Controls.Add(Tb_operation1)
        Controls.Add(Btn_number3)
        Controls.Add(Btn_number4)
        Controls.Add(Btn_number2)
        Controls.Add(Btn_number1)
        Controls.Add(Btn_por)
        Controls.Add(Btn_div)
        Controls.Add(Btn_resta)
        Controls.Add(Btn_suma)
        Controls.Add(Btn_start)
        Controls.Add(Tb_timer)
        Controls.Add(Lbl_time)
        Controls.Add(Lbl_tittle)
        ForeColor = Color.Black
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Lbl_tittle As Label
    Friend WithEvents Lbl_time As Label
    Friend WithEvents Tb_timer As TextBox
    Friend WithEvents Btn_start As Button
    Friend WithEvents Btn_suma As Button
    Friend WithEvents Btn_resta As Button
    Friend WithEvents Btn_div As Button
    Friend WithEvents Btn_por As Button
    Friend WithEvents Btn_number3 As Button
    Friend WithEvents Btn_number4 As Button
    Friend WithEvents Btn_number2 As Button
    Friend WithEvents Btn_number1 As Button
    Friend WithEvents Tb_operation1 As TextBox
    Friend WithEvents Tb_operation7 As TextBox
    Friend WithEvents Tb_operation6 As TextBox
    Friend WithEvents Tb_operation5 As TextBox
    Friend WithEvents Tb_operation4 As TextBox
    Friend WithEvents Tb_operation3 As TextBox
    Friend WithEvents Tb_operation2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Tb_result As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Btn_clearCI As Button
    Friend WithEvents Btn_clearAll As Button
    Friend WithEvents Btn_solution As Button
    Friend WithEvents Btn_next As Button
    Friend WithEvents Tb_partialResult As TextBox
    Friend WithEvents Tb_resultOp As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Tb_resultOp2 As TextBox
    Friend WithEvents Tb_resultOp3 As TextBox
    Friend WithEvents Tb_resultOp4 As TextBox
    Friend WithEvents Tb_resultOp5 As TextBox
    Friend WithEvents Tb_resultOp6 As TextBox
    Friend WithEvents Tb_resultOp7 As TextBox
    Friend WithEvents Tb_resultOp1 As TextBox
    Friend WithEvents Tb_hits As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
End Class
