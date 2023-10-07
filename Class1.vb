Public Class PartialResult
    Public Function ResultPartial(num1 As Integer, operador As String, num2 As Integer) As String
        ' Validar el operador ingresado
        If Not IsValidOperator(operador) Then
            Return Nothing ' Devuelve Nothing en caso de operador no válido
        End If
        ' Validar la división por cero
        If operador = "/" AndAlso num2 = 0 Then
            Return Nothing ' Devuelve Nothing en caso de división por cero
        End If

        Dim rp As Integer

        Select Case operador
            Case "+"
                rp = num1 + num2
            Case "-"
                rp = num1 - num2
            Case "*"
                rp = num1 * num2
            Case "/"
                rp = num1 / num2
        End Select

        ' Comprueba si el resultado es positivo
        If rp < 0 Then
            Return Nothing ' Devuelve Nothing si el resultado no es positivo
        End If

        Return rp.ToString()
    End Function

    Private Function IsValidOperator(operador As String) As Boolean
        Dim operators() As String = {"+", "-", "*", "/"}
        Return operators.Contains(operador)
    End Function

    Public Function CalculateOperation(operation() As String) As String
        If operation.Length <> 7 Then Return Nothing

        Dim result As Integer = Integer.Parse(operation(0))

        For i As Integer = 1 To 6 Step 2
            ' Validar el operador ingresado
            If Not IsValidOperator(operation(i)) Then
                Return Nothing ' Devuelve Nothing en caso de operador no válido
            End If
            ' Validar la división por cero
            If operation(i) = "/" AndAlso Integer.Parse(operation(i + 1)) = 0 Then
                Return Nothing ' Devuelve Nothing en caso de división por cero
            End If

            Select Case operation(i)
                Case "+"
                    result += Integer.Parse(operation(i + 1))
                Case "-"
                    result -= Integer.Parse(operation(i + 1))
                Case "*"
                    result *= Integer.Parse(operation(i + 1))
                Case "/"
                    result /= Integer.Parse(operation(i + 1))
            End Select

            ' Comprueba si el resultado es positivo
            If result < 0 Then
                Return Nothing ' Devuelve Nothing si el resultado no es positivo
            End If
        Next

        Return result.ToString()
    End Function

    Public Function FindValidOperation(numbers() As Integer, operators() As String) As (operation As String(), result As String)
        If numbers.Length < 4 OrElse operators.Length < 3 Then Return (Nothing, Nothing)

        Dim random As New Random()
        Dim result As String = Nothing

        While result Is Nothing
            Dim shuffledNumbers = numbers.OrderBy(Function() random.Next()).ToArray()
            Dim randomOperators = operators.OrderBy(Function() random.Next()).Take(3).ToArray()

            Dim operation = {
                shuffledNumbers(0).ToString(), randomOperators(0),
                shuffledNumbers(1).ToString(), randomOperators(1),
                shuffledNumbers(2).ToString(), randomOperators(2),
                shuffledNumbers(3).ToString()
            }

            result = CalculateOperation(operation)
            If result IsNot Nothing Then
                Return (operation, result)
            End If
        End While

        Return (Nothing, Nothing)
    End Function
End Class
