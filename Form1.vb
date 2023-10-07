Public Class Form1
    Private timerValue As Integer = 60
    Private WithEvents CountdownTimer As New Timer()
    Dim operators() As String = {"+", "-", "*", "/"}
    Dim operador() As Button
    Dim number() As Button
    Dim random As New Random()
    Private result(10) As String
    Dim currentIndex As Integer = 0
    Private Tb_operation() As TextBox
    Private lastButton As Button
    Dim partialResultCalculator As New PartialResult()
    Private Tb_rop() As TextBox
    Private tiempoRestante As Integer = 0
    Private tiempoRestanteAdicional As Integer = 40


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tb_timer.Text = timerValue.ToString()
        CountdownTimer.Interval = 1000 ' Intervalo de 1 segundo

        Tb_operation = {Tb_operation1, Tb_operation2, Tb_operation3, Tb_operation4, Tb_operation5, Tb_operation6, Tb_operation7}
        number = New Button() {Btn_number1, Btn_number2, Btn_number3, Btn_number4}
        operador = New Button() {Btn_suma, Btn_resta, Btn_por, Btn_div}
        Tb_rop = {Tb_resultOp1, Tb_resultOp2, Tb_resultOp3, Tb_resultOp4, Tb_resultOp5, Tb_resultOp6, Tb_resultOp7}
        Tb_timer.Text = timerValue.ToString()
        Tb_hits.Text = 0

        Btn_suma.Text = operators(0)
        Btn_resta.Text = operators(1)
        Btn_por.Text = operators(2)
        Btn_div.Text = operators(3)
        Btn_suma.Enabled = False
        Btn_resta.Enabled = False
        Btn_por.Enabled = False
        Btn_div.Enabled = False
        Btn_number1.Enabled = False
        Btn_number2.Enabled = False
        Btn_number3.Enabled = False
        Btn_number4.Enabled = False
        Btn_clearAll.Enabled = False
        Btn_clearCI.Enabled = False
        Btn_next.Enabled = False
        Btn_solution.Enabled = False

        Tb_timer.Text = timerValue.ToString()

        If Tb_operation.All(Function(tb) Not String.IsNullOrEmpty(tb.Text)) AndAlso Tb_result.Text = Tb_partialResult.Text Then
            ' Incrementa Tb_hits y habilita el botón de siguiente
            If Not String.IsNullOrEmpty(Tb_hits.Text) Then
                Tb_hits.Text = (Integer.Parse(Tb_hits.Text) + 1).ToString()
                Btn_next.Enabled = True

                ' Restablece el tiempo restante al valor del temporizador
                tiempoRestante = timerValue
            End If
        End If

        AddHandler Btn_suma.Click, AddressOf Btn_suma_Click
        AddHandler Btn_resta.Click, AddressOf Btn_resta_Click
        AddHandler Btn_por.Click, AddressOf Btn_por_Click
        AddHandler Btn_div.Click, AddressOf Btn_div_Click
    End Sub

    Private Sub CountdownTimer_Tick(sender As Object, e As EventArgs) Handles CountdownTimer.Tick
        If timerValue > 0 Then
            timerValue -= 1
            Tb_timer.Text = timerValue.ToString()
        Else
            CountdownTimer.Stop()
            MessageBox.Show("El contador ha llegado a cero.")
            Btn_suma.Enabled = False
            Btn_resta.Enabled = False
            Btn_por.Enabled = False
            Btn_div.Enabled = False
            Btn_number1.Enabled = False
            Btn_number2.Enabled = False
            Btn_number3.Enabled = False
            Btn_number4.Enabled = False
            Btn_start.Enabled = True
        End If
    End Sub

    Private Sub Btn_start_Click(sender As Object, e As EventArgs) Handles Btn_start.Click
        CountdownTimer.Start()

        Dim numbers As New List(Of Integer)(Enumerable.Range(0, 10))
        Dim operators As String() = {"+", "-", "*", "/"}
        Dim random As New Random()

        For Each num In number
            If numbers.Count = 0 Then
                Exit For
            End If

            Dim index As Integer = random.Next(numbers.Count)
            num.Text = numbers(index)
            numbers.RemoveAt(index)
            num.Enabled = True
        Next

        ' Crea una instancia de la clase PartialResult
        Dim partialResult As New PartialResult()

        ' Llama a la función FindValidOperation aquí
        Dim operationResult = partialResult.FindValidOperation(number.Select(Function(n) Integer.Parse(n.Text)).ToArray(), operators)

        ' Almacena la operación en Tb_rop y el resultado en Tb_result
        If operationResult.operation IsNot Nothing Then
            For i As Integer = 0 To operationResult.operation.Length - 1
                Tb_rop(i).Text = operationResult.operation(i)
            Next
            Tb_result.Text = operationResult.result
        End If

        Btn_clearAll.Enabled = True
        Btn_clearCI.Enabled = True
        Btn_next.Enabled = False
        Btn_solution.Enabled = True
    End Sub

    Private Sub Btn_clearCI_Click(sender As Object, e As EventArgs) Handles Btn_clearCI.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            Tb_operation(currentIndex).Text = ""
            UpdatePartialResult()
            Dim lastNonEmptyIndex As Integer = currentIndex

            For iterator As Integer = currentIndex To 0 Step -1
                If Tb_operation(iterator).Text <> "" Then
                    lastNonEmptyIndex = iterator
                    Exit For
                End If
            Next

            If IsNumeric(Tb_operation(lastNonEmptyIndex).Text) Then
                For Each i In operador
                    i.Enabled = True
                Next
                For Each i In number
                    i.Enabled = False
                Next
            Else
                For Each i In operador
                    i.Enabled = False
                Next
                For Each i In number
                    If Not Tb_operation.Any(Function(txt) txt.Text = i.Text) Then
                        i.Enabled = True
                    End If
                Next
            End If
        End If
    End Sub


    Private Sub Btn_suma_Click(sender As Object, e As EventArgs)
        If currentIndex < Tb_operation.Length Then
            Dim suma As String = Btn_suma.Text
            result(currentIndex) = suma
            currentIndex += 1
            Tb_operation(currentIndex - 1).Text = result(currentIndex - 1)
            lastButton = Btn_suma
        End If
    End Sub

    Private Sub Btn_resta_Click(sender As Object, e As EventArgs)
        If currentIndex < Tb_operation.Length Then
            Dim resta As String = Btn_resta.Text
            result(currentIndex) = resta
            currentIndex += 1
            Tb_operation(currentIndex - 1).Text = result(currentIndex - 1)
            lastButton = Btn_resta
        End If
    End Sub

    Private Sub Btn_por_Click(sender As Object, e As EventArgs)
        If currentIndex < Tb_operation.Length Then
            Dim por As String = Btn_por.Text
            result(currentIndex) = por
            currentIndex += 1
            Tb_operation(currentIndex - 1).Text = result(currentIndex - 1)
            lastButton = Btn_por
        End If
    End Sub

    Private Sub Btn_div_Click(sender As Object, e As EventArgs)
        If currentIndex < Tb_operation.Length Then
            Dim div As String = Btn_div.Text
            result(currentIndex) = div
            currentIndex += 1
            Tb_operation(currentIndex - 1).Text = result(currentIndex - 1)
            lastButton = Btn_div
        End If
    End Sub
    Private Sub Numero_clik(sender As Object, e As EventArgs) Handles Btn_number1.Click, Btn_number2.Click, Btn_number3.Click, Btn_number4.Click
        Dim btn_num As Button = DirectCast(sender, Button)
        btn_num.Enabled = False ' Deshabilita sólo el botón que fue presionado
        For Each iterator In operador
            iterator.Enabled = True
        Next
        For Each iterator In number
            iterator.Enabled = False
        Next
        If currentIndex < Tb_operation.Length Then
            Dim num As String = btn_num.Text
            result(currentIndex) = num
            currentIndex += 1
            Tb_operation(currentIndex - 1).Text = result(currentIndex - 1)
            lastButton = btn_num
        End If
    End Sub

    Private Sub Operador_clik(sender As Object, e As EventArgs) Handles Btn_suma.Click, Btn_resta.Click, Btn_por.Click, Btn_div.Click
        Dim btn_op As Button = DirectCast(sender, Button)
        For Each iterator In operador
            iterator.Enabled = False
        Next
        For Each iterator In number
            If iterator IsNot lastButton Then
                iterator.Enabled = True
            End If
        Next
        ' Aquí va el resto de tu código para manejar el clic del operador
    End Sub

    Private Sub Btn_clearAll_Click(sender As Object, e As EventArgs) Handles Btn_clearAll.Click
        For Each textBox In Tb_operation
            textBox.Text = ""
        Next

        currentIndex = 0

        For Each numButton In number
            numButton.Enabled = True
        Next

        For Each operatorButton In operador
            operatorButton.Enabled = False
        Next

        Tb_partialResult.Text = ""
        UpdatePartialResult()
    End Sub

    Private Sub Tb_operation1_TextChanged(sender As Object, e As EventArgs)
        Dim partialR As String = Tb_operation(0).Text
        Tb_partialResult.Text = partialR
    End Sub

    Private Sub Tb_operation3_TextChanged(sender As Object, e As EventArgs)
        If Not String.IsNullOrEmpty(Tb_partialResult.Text) AndAlso IsNumeric(Tb_partialResult.Text) AndAlso
        Not String.IsNullOrEmpty(Tb_operation(2).Text) AndAlso IsNumeric(Tb_operation(2).Text) Then

            Dim num1 As Integer = CInt(Tb_partialResult.Text)
            Dim operador As String = Tb_operation(1).Text
            Dim num3 As Integer = CInt(Tb_operation(2).Text)

            Dim partialResultCalculator As New PartialResult()
            Dim resultadoParcial As String = partialResultCalculator.ResultPartial(num1, operador, num3)
            Tb_partialResult.Text = resultadoParcial
        End If
    End Sub
    Private Sub Tb_operation5_TextChanged(sender As Object, e As EventArgs)
        If currentIndex >= 4 AndAlso Not String.IsNullOrEmpty(Tb_partialResult.Text) AndAlso IsNumeric(Tb_partialResult.Text) AndAlso
            Not String.IsNullOrEmpty(Tb_operation(4).Text) AndAlso IsNumeric(Tb_operation(4).Text) Then

            Dim num1 As Integer = CInt(Tb_partialResult.Text)
            Dim operador As String = Tb_operation(3).Text
            Dim num3 As Integer = CInt(Tb_operation(4).Text)

            Dim partialResultCalculator As New PartialResult()
            Dim resultadoParcial As String = partialResultCalculator.ResultPartial(num1, operador, num3)
            Tb_partialResult.Text = resultadoParcial
        End If
    End Sub

    Private Sub Tb_operation7_TextChanged(sender As Object, e As EventArgs)
        If currentIndex >= 6 AndAlso Not String.IsNullOrEmpty(Tb_partialResult.Text) AndAlso IsNumeric(Tb_partialResult.Text) AndAlso
            Not String.IsNullOrEmpty(Tb_operation(6).Text) AndAlso IsNumeric(Tb_operation(6).Text) Then

            Dim num1 As Integer = CInt(Tb_partialResult.Text)
            Dim operador As String = Tb_operation(5).Text
            Dim num3 As Integer = CInt(Tb_operation(6).Text)

            Dim partialResultCalculator As New PartialResult()
            Dim resultadoParcial As String = partialResultCalculator.ResultPartial(num1, operador, num3)
            Tb_partialResult.Text = resultadoParcial
        End If

        ValidarResultado()
    End Sub

    Private Sub ValidarResultado()
        If Tb_result.Text = Tb_partialResult.Text Then
            timerValue += 40
            ' Incrementa Tb_hits en 1
            If Not String.IsNullOrEmpty(Tb_hits.Text) Then
                Tb_hits.Text = (Integer.Parse(Tb_hits.Text) + 1).ToString()
            End If
            ' Detiene el temporizador
            CountdownTimer.Stop()
            ' Habilita el botón "Siguiente"
            Btn_next.Enabled = True
        End If
    End Sub

    Private Sub UpdatePartialResult()
        Dim num1 As Integer
        Dim num3 As Integer
        Dim operador As String = ""

        For i As Integer = 0 To Tb_operation.Length - 1
            Dim text As String = Tb_operation(i).Text.Trim()

            If IsNumeric(text) Then
                If operador = "" Then
                    num1 = CInt(text)
                Else
                    num3 = CInt(text)
                End If
            ElseIf Array.IndexOf(operators, text) >= 0 Then
                operador = text
            End If
        Next

        If operador <> "" Then
            Dim partialResultCalculator As New PartialResult()
            Dim resultadoParcial As String = partialResultCalculator.ResultPartial(num1, operador, num3)
            Tb_partialResult.Text = resultadoParcial
        Else
            Tb_partialResult.Text = ""
        End If
    End Sub

    Private Sub Btn_solution_Click(sender As Object, e As EventArgs) Handles Btn_solution.Click
        Dim partialResult As New PartialResult()
        Dim operation(Tb_rop.Length - 1) As String

        For i As Integer = 0 To Tb_rop.Length - 1
            Tb_operation(i).Text = Tb_rop(i).Text
            operation(i) = Tb_rop(i).Text
        Next

        ' Calculate the operation
        Dim result As String = partialResult.CalculateOperation(operation)

        ' Display the result in Tb_partialResult
        Tb_partialResult.Text = result

        ' Detiene el tiempo
        CountdownTimer.Stop()

        ' Habilita el botón de siguiente
        Btn_next.Enabled = True
    End Sub

    Private Sub Btn_next_Click(sender As Object, e As EventArgs) Handles Btn_next.Click
        ' Llama a la función para limpiar todos los campos de operación
        Btn_clearAll_Click(Nothing, Nothing)
        Dim numbers As New List(Of Integer)(Enumerable.Range(0, 10))
        Dim operators As String() = {"+", "-", "*", "/"}
        Dim random As New Random()

        For Each num In number
            If numbers.Count = 0 Then
                Exit For
            End If

            Dim index As Integer = random.Next(numbers.Count)
            num.Text = numbers(index)
            numbers.RemoveAt(index)
            num.Enabled = True
        Next

        ' Crea una instancia de la clase PartialResult
        Dim partialResult As New PartialResult()

        ' Llama a la función FindValidOperation aquí
        Dim operationResult = partialResult.FindValidOperation(number.Select(Function(n) Integer.Parse(n.Text)).ToArray(), operators)

        ' Almacena la operación en Tb_rop y el resultado en Tb_result
        If operationResult.operation IsNot Nothing Then
            For i As Integer = 0 To operationResult.operation.Length - 1
                Tb_rop(i).Text = operationResult.operation(i)
            Next
            Tb_result.Text = operationResult.result
        End If
        CountdownTimer.Start()

        Btn_clearAll.Enabled = True
        Btn_clearCI.Enabled = True
        Btn_next.Enabled = False
        Btn_solution.Enabled = True
    End Sub

    Private Sub Tb_operation_TextChanged(sender As Object, e As EventArgs) Handles Tb_operation1.TextChanged, Tb_operation2.TextChanged, Tb_operation3.TextChanged, Tb_operation4.TextChanged, Tb_operation5.TextChanged, Tb_operation6.TextChanged, Tb_operation7.TextChanged
        ' Verificar si todos los TextBox del arreglo contienen valores no nulos o en blanco
        Dim arregloCompleto = Tb_operation.All(Function(tb) Not String.IsNullOrEmpty(tb.Text))

        If arregloCompleto AndAlso Tb_result.Text = Tb_partialResult.Text Then
            ' Incrementar el contador de aciertos en 1
            If Not String.IsNullOrEmpty(Tb_hits.Text) Then
                Tb_hits.Text = (Integer.Parse(Tb_hits.Text) + 1).ToString()
            End If

            ' Sumar 40 al temporizador
            timerValue += 40
            Tb_timer.Text = timerValue.ToString()

            ' Reiniciar el temporizador automáticamente
            CountdownTimer.Stop()
            CountdownTimer.Start()

            ' Habilitar el botón de siguiente
            Btn_next.Enabled = True
        Else
            ' Si el arreglo no está completo o no coincide con el resultado, asegúrate de que el botón de siguiente esté deshabilitado
            Btn_next.Enabled = False
        End If
    End Sub

End Class
