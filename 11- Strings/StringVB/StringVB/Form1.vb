Public Class frmStringVB

    Dim cantPalabras As Integer
    Dim cantVocales As Integer
    Dim cantConsonantes As Integer
    Dim cantEspacios As Integer
    Dim cantSimbolos As Integer
    Dim cantNumeros As Integer

    Private Sub txtString_KeyUp(sender As Object, e As KeyEventArgs) Handles txtSttring.KeyUp

        If e.KeyCode = Keys.Enter Then



            cantVocales = 0
            cantPalabras = 0
            cantNumeros = 0
            cantConsonantes = 0
            cantEspacios = 0
            cantSimbolos = 0
            Dim palabras() As String = txtSttring.Text.Split(" ")
            For Each palabra As String In palabras


                cantPalabras = (cantPalabras + 1)




                For Each letra As Char In palabra

                    If letra Like "[0-9]" Then

                        cantNumeros = cantNumeros + 1


                    ElseIf letra Like "[aeiou,AEIOU]" Then

                        cantVocales = cantVocales + 1


                    ElseIf letra Like "[QqWwRrTtYyPpSsDdFfGgHhJjKkLlZzXxCcVvBbNnMm]" Then

                        cantConsonantes = cantConsonantes + 1


                    Else

                        cantSimbolos = cantSimbolos + 1


                    End If

                Next


            Next

            For Each letra As Char In txtSttring.Text

                If letra Like " " Then

                    cantEspacios = cantEspacios + 1

                End If

            Next


            MsgBox("Cantidad de palabras: " & cantPalabras & vbCrLf & "Cantidad de vocales: " & cantVocales & vbCrLf & "Cantidad de consonantes: " & cantConsonantes & vbCrLf & "Cantidad de numeros: " & cantNumeros & vbCrLf & "Cantidad de simbolos: " & cantSimbolos & vbCrLf & "Cantidad de espacios: " & cantEspacios)


        End If

    End Sub
End Class
