Imports System.Globalization
Imports System.Text.RegularExpressions
Imports PersonasVB

Public Class Form1
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtNombre.Text = ""
        txtPater.Text = ""
        txtMater.Text = ""
        txtEmail.Text = ""
        txtTel.Text = ""
        Fecha.Value = DateTime.Now
        labRFC.Visible = False
        labRFC.Text = "XXXX000000"
        adverEmail.Visible = False
        adverFecha.Visible = False
        adverNombre.Visible = False
        adverPater.Visible = False
        adverMat.Visible = False
        adverTele.Visible = False
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim c As Contacto = New Contacto(txtTel.Text, txtEmail.Text, txtNombre.Text, txtPater.Text, txtMater.Text, Fecha.Value)
        labRFC.Text = c.RFC()
        labRFC.Visible = True
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtMater.TextChanged

        If (String.IsNullOrEmpty(txtMater.Text) Or String.IsNullOrWhiteSpace(txtMater.Text)) Then

            adverMat.Visible = True

        Else

            adverMat.Visible = False
            If (textos(txtMater.Text)) Then

                adverMat.Visible = False

            Else
                adverMat.Visible = True
            End If
        End If
        FechaChanged()
        If (adverEmail.Visible = False And adverFecha.Visible = False And adverNombre.Visible = False And adverMat.Visible = False And adverPater.Visible = False And adverTele.Visible = False) Then


            If (String.IsNullOrEmpty(txtEmail.Text) Or String.IsNullOrWhiteSpace(txtEmail.Text) Or
                    String.IsNullOrEmpty(txtTel.Text) Or String.IsNullOrWhiteSpace(txtTel.Text) Or
                    String.IsNullOrEmpty(txtNombre.Text) Or String.IsNullOrWhiteSpace(txtNombre.Text) Or
                    String.IsNullOrEmpty(txtMater.Text) Or String.IsNullOrWhiteSpace(txtMater.Text) Or
                    String.IsNullOrEmpty(txtPater.Text) Or String.IsNullOrWhiteSpace(txtPater.Text)
                    ) Then
                btnCalcular.Enabled = False
            Else
                btnCalcular.Enabled = True
            End If

        Else
            btnCalcular.Enabled = False
        End If
    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        If (String.IsNullOrEmpty(txtNombre.Text) Or String.IsNullOrWhiteSpace(txtNombre.Text)) Then
            adverNombre.Visible = True

        Else

            adverNombre.Visible = False
            Dim n As String = txtNombre.Text.Replace(" ", "")
            Dim cant As Integer = 0
            If (textos(n)) Then

                adverNombre.Visible = False
                For i As Integer = 0 To txtNombre.Text.Length - 1 Step 1

                    If (txtNombre.Text.Substring(i, 1) = " ") Then
                        cant += 1
                    End If
                Next
                If (cant > 2) Then

                    adverNombre.Visible = True

                Else
                    adverNombre.Visible = False
                End If

            Else
                adverNombre.Visible = True
            End If
        End If
        FechaChanged()
        If (adverEmail.Visible = False And adverFecha.Visible = False And adverNombre.Visible = False And adverMat.Visible = False And adverPater.Visible = False And adverTele.Visible = False) Then


            If (String.IsNullOrEmpty(txtEmail.Text) Or String.IsNullOrWhiteSpace(txtEmail.Text) Or
                    String.IsNullOrEmpty(txtTel.Text) Or String.IsNullOrWhiteSpace(txtTel.Text) Or
                    String.IsNullOrEmpty(txtNombre.Text) Or String.IsNullOrWhiteSpace(txtNombre.Text) Or
                    String.IsNullOrEmpty(txtMater.Text) Or String.IsNullOrWhiteSpace(txtMater.Text) Or
                    String.IsNullOrEmpty(txtPater.Text) Or String.IsNullOrWhiteSpace(txtPater.Text)
                    ) Then

                btnCalcular.Enabled = False

            Else

                btnCalcular.Enabled = True
            End If

        Else
            btnCalcular.Enabled = False
        End If
    End Sub

    Private Sub txtPater_TextChanged(sender As Object, e As EventArgs) Handles txtPater.TextChanged
        If (String.IsNullOrEmpty(txtPater.Text) Or String.IsNullOrWhiteSpace(txtPater.Text)) Then

            adverPater.Visible = True

        Else

            adverPater.Visible = False
            If (textos(txtPater.Text)) Then


                adverPater.Visible = False

            Else
                adverPater.Visible = True
            End If
        End If
            FechaChanged()
                If (adverEmail.Visible = False And adverFecha.Visible = False And adverNombre.Visible = False And adverMat.Visible = False And adverPater.Visible = False And adverTele.Visible = False) Then


                    If (String.IsNullOrEmpty(txtEmail.Text) Or String.IsNullOrWhiteSpace(txtEmail.Text) Or
                    String.IsNullOrEmpty(txtTel.Text) Or String.IsNullOrWhiteSpace(txtTel.Text) Or
                    String.IsNullOrEmpty(txtNombre.Text) Or String.IsNullOrWhiteSpace(txtNombre.Text) Or
                    String.IsNullOrEmpty(txtMater.Text) Or String.IsNullOrWhiteSpace(txtMater.Text) Or
                    String.IsNullOrEmpty(txtPater.Text) Or String.IsNullOrWhiteSpace(txtPater.Text)
                    ) Then

                        btnCalcular.Enabled = False

                    Else

                        btnCalcular.Enabled = True
                    End If

                Else
                    btnCalcular.Enabled = False
                End If
    End Sub
    Private Sub Fecha_ValueChanged(sender As Object, e As EventArgs) Handles Fecha.ValueChanged
        Dim difer As DateTime = Fecha.Value
        If (difer.AddYears(18).CompareTo(DateTime.Now) > 0) Then

            adverFecha.Visible = True

        Else
            adverFecha.Visible = False
        End If

        If (adverEmail.Visible = False And adverFecha.Visible = False And adverNombre.Visible = False And adverMat.Visible = False And adverPater.Visible = False And adverTele.Visible = False) Then


                If (String.IsNullOrEmpty(txtEmail.Text) Or String.IsNullOrWhiteSpace(txtEmail.Text) Or
                String.IsNullOrEmpty(txtTel.Text) Or String.IsNullOrWhiteSpace(txtTel.Text) Or
                String.IsNullOrEmpty(txtNombre.Text) Or String.IsNullOrWhiteSpace(txtNombre.Text) Or
                String.IsNullOrEmpty(txtMater.Text) Or String.IsNullOrWhiteSpace(txtMater.Text) Or
                String.IsNullOrEmpty(txtPater.Text) Or String.IsNullOrWhiteSpace(txtPater.Text)
                ) Then

                    btnCalcular.Enabled = False

                Else

                    btnCalcular.Enabled = True
                End If

            Else
                btnCalcular.Enabled = False
            End If
    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        adverEmail.Visible = False
        If (String.IsNullOrEmpty(txtEmail.Text)) Then
            adverEmail.Visible = True
        Else
            If (IsValidEmail(txtEmail.Text)) Then

            Else
                adverEmail.Visible = True
            End If
        End If
        FechaChanged()
        If (adverEmail.Visible = False And adverFecha.Visible = False And adverNombre.Visible = False And adverMat.Visible = False And adverPater.Visible = False And adverTele.Visible = False) Then


            If (String.IsNullOrEmpty(txtEmail.Text) Or String.IsNullOrWhiteSpace(txtEmail.Text) Or
            String.IsNullOrEmpty(txtTel.Text) Or String.IsNullOrWhiteSpace(txtTel.Text) Or
            String.IsNullOrEmpty(txtNombre.Text) Or String.IsNullOrWhiteSpace(txtNombre.Text) Or
            String.IsNullOrEmpty(txtMater.Text) Or String.IsNullOrWhiteSpace(txtMater.Text) Or
            String.IsNullOrEmpty(txtPater.Text) Or String.IsNullOrWhiteSpace(txtPater.Text)
            ) Then

                btnCalcular.Enabled = False

            Else

                btnCalcular.Enabled = True
            End If

        Else
            btnCalcular.Enabled = False
        End If
    End Sub
    Private Sub txtTel_TextChanged(sender As Object, e As EventArgs) Handles txtTel.TextChanged

        txtTel.Text.Replace(" ", "")
        adverTele.Visible = False
        If (txtTel.Text.Length = 10) Then
            If (txtTel.Text.StartsWith("7") Or txtTel.Text.StartsWith("8") Or txtTel.Text.StartsWith("9")) Then
                For i As Integer = 0 To txtTel.Text.Length - 1 Step 1
                    If (Asc(txtTel.Text.Substring(i, 1)) <= 57 And Asc(txtTel.Text.Substring(i, 1)) >= 48) Then

                    Else
                        adverTele.Visible = True
                    End If
                Next
            Else
                adverTele.Visible = True
            End If
        Else
        adverTele.Visible = True
        End If
        FechaChanged()
                If (adverEmail.Visible = False And adverFecha.Visible = False And adverNombre.Visible = False And adverMat.Visible = False And adverPater.Visible = False And adverTele.Visible = False) Then


                    If (String.IsNullOrEmpty(txtEmail.Text) Or String.IsNullOrWhiteSpace(txtEmail.Text) Or
                    String.IsNullOrEmpty(txtTel.Text) Or String.IsNullOrWhiteSpace(txtTel.Text) Or
                    String.IsNullOrEmpty(txtNombre.Text) Or String.IsNullOrWhiteSpace(txtNombre.Text) Or
                    String.IsNullOrEmpty(txtMater.Text) Or String.IsNullOrWhiteSpace(txtMater.Text) Or
                    String.IsNullOrEmpty(txtPater.Text) Or String.IsNullOrWhiteSpace(txtPater.Text)
                    ) Then

                        btnCalcular.Enabled = False

                    Else

                        btnCalcular.Enabled = True
                    End If

                Else
                    btnCalcular.Enabled = False
                End If
    End Sub
    Private Function textos(a As String) As Boolean
        For i As Integer = 0 To a.Length - 1 Step 1
            If (Asc(a.Substring(i, 1)) <= 90 And Asc(a.Substring(i, 1)) >= 65) Then

            ElseIf (Asc(a.Substring(i, 1)) <= 122 And Asc(a.Substring(i, 1)) >= 97) Then

            ElseIf (a.Substring(i, 1) = "á" Or a.Substring(i, 1) = "é" Or a.Substring(i, 1) = "í" Or a.Substring(i, 1) = "ó" Or
                    a.Substring(i, 1) = "ú" Or a.Substring(i, 1) = "ü" Or a.Substring(i, 1) = "Á" Or a.Substring(i, 1) = "É" Or
                    a.Substring(i, 1) = "Í" Or a.Substring(i, 1) = "Ó" Or a.Substring(i, 1) = "Ü" Or a.Substring(i, 1) = "Ú" Or
                    a.Substring(i, 1) = "ñ" Or a.Substring(i, 1) = "Ñ") Then

            Else
                Return False
            End If
        Next
        Return True

    End Function

    Private Sub FechaChanged()

        Dim difer As DateTime = Fecha.Value
        If (difer.AddYears(18).CompareTo(DateTime.Now) > 0) Then

            adverFecha.Visible = True

        Else
            adverFecha.Visible = False
        End If
    End Sub
    Public Function IsValidEmail(email As String) As Boolean

        If (String.IsNullOrWhiteSpace(email)) Then
            Return False
        End If

        Try

            Dim DomainMaper As MatchEvaluator = New MatchEvaluator(AddressOf DomainMapper)
            ' Normalize the domain
            email = Regex.Replace(email, "(@)(.+)$", DomainMaper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200))


        Catch e As RegexMatchTimeoutException

            Return False

        Catch e As ArgumentException

            Return False


        End Try

        Try

            Return Regex.IsMatch(email, "^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250))

        Catch e As RegexMatchTimeoutException

            Return False
    End Try

    End Function
    Private Function DomainMapper(match As Match) As String

        '// Use IdnMapping class to convert Unicode domain names.
        Dim idn = New IdnMapping()

        ' // Pull out And process domain name (throws ArgumentException on invalid)
        Dim domainName As String = idn.GetAscii(match.Groups(2).Value)

        Return match.Groups(1).Value + domainName
    End Function
End Class
